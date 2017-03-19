using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardCommon
{
    public class MessageBoardException : Exception
    {
        public MessageBoardException()
            : base() { }

        public MessageBoardException(string message)
            : base(message)
        {
            
        }

        public MessageBoardException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public MessageBoardException(string message, Exception innerException)
            : base(message, innerException) { }

        public MessageBoardException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }
    }
}
