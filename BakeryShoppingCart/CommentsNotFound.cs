using System;
using System.Runtime.Serialization;

namespace BakeryShoppingCart
{
    [Serializable]
    internal class CommentsNotFound : Exception
    {
        public CommentsNotFound()
        {
        }

        public CommentsNotFound(string message) : base(message)
        {
        }

        public CommentsNotFound(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CommentsNotFound(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}