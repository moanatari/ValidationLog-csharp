using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationLog_csharp
{
    class MessageValidationException : MessageValidation
    {
        public Exception Exception { get; set; }

        public MessageValidationException(Exception ex)
        {
            Exception = ex;
        }

        public override string Message()
        {
            return Exception.Message;
        }
    }
}
