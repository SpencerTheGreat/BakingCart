using System;
using System.Runtime.Serialization;

namespace BakeryShoppingCart.Repositories.Implementation
{
    [Serializable]
    internal class CakeNotFound : Exception
    {
        public CakeNotFound()
        {
        }

        public CakeNotFound(string message) : base(message)
        {
        }

        public CakeNotFound(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CakeNotFound(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}