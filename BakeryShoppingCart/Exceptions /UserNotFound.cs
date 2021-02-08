using System;
namespace BakeryShoppingCart.Exceptions
{
    public class UserNotFound : Exception
    {
        private string v;

        public UserNotFound()
        {
        }

        public UserNotFound(string v)
        {
            this.v = v;
        }
    }
}
