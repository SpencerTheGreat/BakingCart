﻿using System;
using BakeryShoppingCart.Models;

namespace BakeryShoppingCart
{
    class Program
    {
        static void Main()
        {
            Posts post = new Posts();
            post.PostId = 1;
            post.Post = "This is a post";

            Console.WriteLine("The value of my first property is: " + post.PostId);
            Console.WriteLine("The value of my second property is: " + post.Post);
        }

    }
}