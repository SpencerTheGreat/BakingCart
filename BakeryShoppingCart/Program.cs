using System;
using System.Collections.Generic;
using System.Linq;
using BakeryShoppingCart.DTOS;
using BakeryShoppingCart.Models;

namespace BakeryShoppingCart
{
    class Program
    {
        private static User newUser1;

        static void Main()
        {
            try
            {
                List<User> userList = new List<User>();

                User newUser = new User();
                newUser.Email = "email@somewhere.com";
                newUser.Password = "Password";
                newUser.UserId = 1;
                newUser.UserName = "Cory";
                userList.Add(newUser1);

                User newUser2 = new User();
                newUser.Email = "email@somewhere.com";
                newUser.Password = "Password2";
                newUser.UserId = 2;
                newUser.UserName = "Random person";
                userList.Add(newUser2);

                User newUser3 = new User();
                newUser.Email = "email@somewhere.com";
                newUser.Password = "Password3";
                newUser.UserId = 3;
                newUser.UserName = "Random person";
                userList.Add(newUser3);

                User newUser4 = new User();
                newUser.Email = "email@somewhere.com";
                newUser.Password = "Password4";
                newUser.UserId = 4;
                newUser.UserName = "Random person";
                userList.Add(newUser4);

                User newUser5 = new User();
                newUser.Email = "email@somewhere.com";
                newUser.Password = "Password5";
                newUser.UserId = 5;
                newUser.UserName = "Random person";
                userList.Add(newUser5);

                User newUser6 = new User();
                newUser.Email = "email@somewhere.com";
                newUser.Password = "Password6";
                newUser.UserId = 6;
                newUser.UserName = "Random person";
                userList.Add(newUser6);

                User newUser7 = new User();
                newUser.Email = "email@somewhere.com";
                newUser.Password = "Password7";
                newUser.UserId = 7;
                newUser.UserName = "Random person";
                userList.Add(newUser7);

                User newUser8 = new User();
                newUser.Email = "email@somewhere.com";
                newUser.Password = "Password8";
                newUser.UserId = 8;
                newUser.UserName = "Random person";
                userList.Add(newUser8);

                User newUser9 = new User();
                newUser.Email = "email@somewhere.com";
                newUser.Password = "Password9";
                newUser.UserId = 9;
                newUser.UserName = "Random person";
                userList.Add(newUser9);

                User newUser10 = new User();
                newUser.Email = "email@somewhere.com";
                newUser.Password = "Password10";
                newUser.UserId = 10;
                newUser.UserName = "Random person";
                userList.Add(newUser10);

                userList = userList.Where(user => user.UserName == "cory").ToList();

                if (userList.Count > 0)

                {
                    Console.WriteLine("User found and they have the following ");
                    string format = "My user has theses properties: " +
                        "Email: {0}, UserId: {1}, Password: {2}," +
                        "UserName: {3}";

                    foreach (var user in userList)
                    {
                        Console.WriteLine(format, user.Email, user.UserId,
                            user.Password, user.UserName);
                    }

                }
                else
                {
                    throw new UserNotFoundConsole("No users found for the specified query");
                }
            }
            catch (UserNotFound exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Program has ended");
            }
        }
    }
}
public class UserNotFound : Exception
{
    public UserNotFound(string errorMessage) : base(errorMessage)
    {

    }
}

