﻿using System;

namespace _33
{
    public class CanNotRegisterUserException : Exception
    {
        public CanNotRegisterUserException(User user, string message) : base(message)
        {
            Id = user?.Id?.Value;
        }

        
        public string Id { get; }
        public string MailAddress { get; }
    }
}
