using System;
using System.Runtime.Serialization;

namespace BakeryShoppingCart
{
    [Serializable]
    internal class UserNotFoundConsole : Exception
    {
        public UserNotFoundConsole()
        {
        }

        public UserNotFoundConsole(string message) : base(message)
        {
        }

        public UserNotFoundConsole(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UserNotFoundConsole(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}