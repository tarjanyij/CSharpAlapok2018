using System;
using System.Runtime.Serialization;

namespace _02Exception
{
    [Serializable]
    internal class ConfuseCurrencyException : Exception
    {
        public ConfuseCurrencyException()
        {
        }

        public ConfuseCurrencyException(string message) : base(message)
        {
        }

        public ConfuseCurrencyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ConfuseCurrencyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}