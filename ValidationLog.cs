using System;
using System.Collections.Generic;

namespace ValidationLog_csharp
{
    public class ValidationLog
    {
        public bool IsValide { get; set; }
        public List<MessageValidation> Messages { get; set; }

        public ValidationLog()
        {
            IsValide = true;
            Messages = new List<MessageValidation>();
        }

        public void Add(string message)
        {
            Messages.Add(new MessageValidationString(message));
            IsValide = false;
        }

        public void Add(Exception ex)
        {
            Messages.Add(new MessageValidationException(ex));
            IsValide = false;
        }

        public List<String> GetMessagesList()
        {
            List<String> MessagesArray = new List<string>();
            foreach (MessageValidation item in this.Messages)
            {
                MessagesArray.Add(item.Message());
            }
            return MessagesArray;
        }

        public String[] GetMessagesArray()
        {
            return GetMessagesList().ToArray();
        }

        public string GetMessagesText()
        {
            string MessagesText = "";
            foreach (MessageValidation item in Messages)
            {
                MessagesText += $"{item.Message()}\n";
            }
            return MessagesText;
        }
    }
}
