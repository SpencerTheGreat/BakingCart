using System;
using System.Collections.Generic;
using System.Linq;
using BakeryShoppingCart.DTOS;
using BakeryShoppingCart.Models;
using BakeryShoppingCart.Repositories;
using BakeryShoppingCart.Repositories.Implementation;

namespace BakeryShoppingCart
{
    class Program
    {
        static void Main()
        {
            UserRepository repository =
                new UserRepository();

            User user = new User();
            user.UserName = "Cory";
            user.UserId = 1;
            user.Password = "Password";
            user.Email = "email@somewhere.com";

            repository.Save(user);

            repository.GetAllUsersByName("Cory");

        }
    }
}
