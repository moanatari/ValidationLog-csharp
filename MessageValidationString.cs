using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationLog_csharp
{
    class MessageValidationString : MessageValidation
    {
        public string ValidationMessage { get; set; }

        public MessageValidationString(string message)
        {
            ValidationMessage = message;
        }

        public override string Message()
        {
            return ValidationMessage;
        }
    }
}
