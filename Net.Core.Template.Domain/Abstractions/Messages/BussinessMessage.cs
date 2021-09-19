﻿namespace Net.Core.Template.Domain.Abstractions.Messages
{
    public class BussinessMessage
    {
        public BussinessMessage(string type, string message)
        {
            Type = type;
            Message = message;
        }

        public string Type { get; private set; }
        public string Message { get; private set; }
    }
}
