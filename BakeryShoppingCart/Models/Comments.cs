using System;
namespace BakeryShoppingCart.Models
{
    public class Comments
    {
        internal string TheComment;

        public Comments()
        {
        }
        public string ImagePath { get; set; }
        public int CommentId { get; internal set; }
        public object CakeId { get; internal set; }
    }
}
