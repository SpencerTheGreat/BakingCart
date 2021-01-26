using System;
using BakeryShoppingCart.DTOS;
using BakeryShoppingCart.Models;

namespace BakeryShoppingCart
{
    class Program
    {
        static void Main()
        {
            CommentDTO comment = new CommentDTO();
            comment.TheComment = "This is a comment";

            Console.WriteLine("The value of my first property is: " + comment.TheComment);
            
        }

    }
}