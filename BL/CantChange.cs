using System;
using System.Runtime.Serialization;

namespace BL
{
    [Serializable]
    internal class CantChange : Exception
    {
        private string v;
        private int key;

        public CantChange()
        {
        }

        public CantChange(string message) : base(message)
        {
        }

        public CantChange(string v, int key)
        {
            this.v = v;
            this.key = key;
        }

        public CantChange(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CantChange(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}