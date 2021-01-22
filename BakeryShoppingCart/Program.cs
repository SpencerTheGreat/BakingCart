using System;
using BakeryShoppingCart.Models;

namespace BakeryShoppingCart
{
    class Program
    { 
        static void Main(string[] args)
        {
            User newUser = new User();
            newUser.UserName = "Cory";
            newUser.Password = "PAssword";
            newUser.Email = "email@somewhere.com";

            Console.WriteLine("My user is: " + newUser.UserName);
            Console.WriteLine("And my password is: " + newUser.Password);
            Console.WriteLine("My email is: " + newUser.Email);

        }
    }
}