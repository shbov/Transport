using System;
using System.Runtime.Serialization;

namespace EKRLib
{
    [Serializable]
    public class TransportException : Exception
    {
        public TransportException()
        {
        }

        public TransportException(string message) : base(message)
        {
        }

        public TransportException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TransportException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}