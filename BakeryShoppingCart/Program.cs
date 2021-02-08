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
            FileManager.FileManagerClass fileManager
                = new FileManagerClass();

            fileManager.CreateAFile("MyFile.txt");


        }
    }
}
