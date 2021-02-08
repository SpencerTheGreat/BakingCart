using System;
using System.Collections.Generic;
using System.Linq;
using BakeryShoppingCart.DTOS;
using BakeryShoppingCart.FileManager;
using BakeryShoppingCart.Models;
using BakeryShoppingCart.Repositories;
using BakeryShoppingCart.Repositories.Implementation;

namespace BakeryShoppingCart
{
    class Program
    {
        static void Main()
        {

            ShoppingCart cart =
                new ShoppingCart();

            cart.PrintMenu();

        }
    }
}
