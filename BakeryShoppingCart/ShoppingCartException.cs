using System;
using System.Runtime.Serialization;

namespace BakeryShoppingCart
{
    [Serializable]
    internal class ShoppingCartException : Exception
    {
        public ShoppingCartException()
        {
        }

        public ShoppingCartException(string message) : base(message)
        {
        }

        public ShoppingCartException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ShoppingCartException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}