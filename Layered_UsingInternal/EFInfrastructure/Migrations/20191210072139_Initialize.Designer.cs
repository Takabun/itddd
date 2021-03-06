﻿// <auto-generated />
using EFInfrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFInfrastructure.Migrations
{
    [DbContext(typeof(ItdddDbContext))]
    [Migration("20191210072139_Initialize")]
    partial class Initialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFInfrastructure.Persistence.DataModels.CircleDataModel", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("OwnerId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Circles");
                });

            modelBuilder.Entity("EFInfrastructure.Persistence.DataModels.UserCircle", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("CircleId");

                    b.HasKey("UserId", "CircleId");

                    b.HasIndex("CircleId");

                    b.ToTable("UserCircles");
                });

            modelBuilder.Entity("EFInfrastructure.Persistence.DataModels.UserDataModel", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EFInfrastructure.Persistence.DataModels.CircleDataModel", b =>
                {
                    b.HasOne("EFInfrastructure.Persistence.DataModels.UserDataModel", "Owner")
                        .WithMany("OwnedCircles")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("EFInfrastructure.Persistence.DataModels.UserCircle", b =>
                {
                    b.HasOne("EFInfrastructure.Persistence.DataModels.CircleDataModel", "Circle")
                        .WithMany("CircleMembers")
                        .HasForeignKey("CircleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EFInfrastructure.Persistence.DataModels.UserDataModel", "User")
                        .WithMany("MemberOf")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
