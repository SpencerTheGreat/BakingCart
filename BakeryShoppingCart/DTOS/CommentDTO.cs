using System;
namespace BakeryShoppingCart.DTOS
{
    public class CommentDTO
    {
        public CommentDTO()
        {
          
    }
        public string ImagePath { get; set; }
        public string TheComment { get; internal set; }
    }
}
