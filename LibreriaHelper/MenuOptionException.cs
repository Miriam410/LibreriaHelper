using System;
using System.Runtime.Serialization;

namespace LibreriaHelper.Menu
{
    [Serializable]
    public class MenuOptionException : Exception
    {
        public MenuOptionException()
        {
        }

        public MenuOptionException(string message) : base(message)
        {
        }

        public MenuOptionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MenuOptionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}