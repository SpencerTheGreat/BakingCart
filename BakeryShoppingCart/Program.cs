using System;
using BakeryShoppingCart.Models;

namespace BakeryShoppingCart
{
    class Program
    {
        static void Main()
        {
            ConcatanationOfStrings("my firts string", "my second string");
        }
        static void ConcatanationOfStrings(string parameter1, string parameter2)
        {
            {
                string result = parameter1 + " " + parameter2;
                Console.WriteLine(result);
            }
        }

    }
}