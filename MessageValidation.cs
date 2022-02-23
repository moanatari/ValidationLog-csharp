using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationLog_csharp
{
    public abstract class MessageValidation
    {
        // public string Message { get; set; }
        public DateTime DateTime { get; set; }

        public MessageValidation()
        {
            DateTime = DateTime.Now;
        }

        public virtual String Message() 
        {
            return "";
        }

    }
}
