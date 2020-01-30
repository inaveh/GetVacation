using System;
using System.Runtime.Serialization;

namespace IBl
{
    [Serializable]
    internal class MissingException : Exception
    {
        private string v;
        private int Key;

        public MissingException()
        {
        }

        public MissingException(string message) : base(message)
        {
            this.v = message;
        }

        public MissingException(string v, int key)
        {
            this.v = v;
            this.Key = key;
        }

        public MissingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MissingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}