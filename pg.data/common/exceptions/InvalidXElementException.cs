using System;
using System.Runtime.Serialization;

namespace pg.data.common.exceptions
{
    public class InvalidXElementException : Exception
    {
        public InvalidXElementException()
        {
        }

        public InvalidXElementException(string message) : base(message)
        {
        }

        public InvalidXElementException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidXElementException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}