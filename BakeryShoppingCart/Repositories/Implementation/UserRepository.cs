using System;
using System.Collections.Generic;
using System.Linq;
using BakeryShoppingCart.Models;

namespace BakeryShoppingCart.Repositories.Implementation
{
    public class UserRepository : MainRepository<User>, IUser_Repository
    {
        private object userName;
        private object user;

        public UserRepository()
        {
        }

        public void GetAllUsersByName(string name)

        {
            List<User> result =
                  currentDatabase.Where(user =>
                  user.UserName.Contains(name)).ToList();
            if (result.Count > 0)
            {
                Console.WriteLine("Here are all the users on the database with the user name");




                Console.WriteLine("You are looking for users with the name: " + name);
                foreach (var user in currentDatabase)



                {
                    Console.WriteLine(user.Email);
                    Console.WriteLine(user.Password);
                    Console.WriteLine(user.UserId);
                    Console.WriteLine(user.UserName);
                }

            }
            else
            {
                Console.WriteLine("There are no users on the database");
            }

        }
    }
}

