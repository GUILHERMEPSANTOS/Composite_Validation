using System;
using System.Collections.Generic;

namespace CompositeValidation.Notifications
{
    public class Notification
    {
        public string Key { get; set; }
        public List<string> Messages { get; set; }
        public bool IsValid { get; set; }

        public Notification()
        {
            Messages = new List<string>();
            IsValid = true;
        }

        public Notification(string key, string message, bool isValid)
        {
            Key = key;
            Messages = new List<string> { message };
            IsValid = isValid;
        }

        public Notification(bool isValid)
        {
            Messages = new List<string>();
            IsValid = isValid;
        }
    }
}
