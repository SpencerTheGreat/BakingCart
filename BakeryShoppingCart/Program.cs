using System;
using System.Collections.Generic;
using BakeryShoppingCart.DTOS;
using BakeryShoppingCart.Models;

namespace BakeryShoppingCart
{
    class Program
    {
        private static int x;

        static void Main()
        {
            int result = 0;

            for (int x = 1; x < 21; x++);
            {
                result = result + x;
            }
            Console.WriteLine(result);
        }
    }
}
