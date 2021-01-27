using System;
using System.Collections.Generic;
using BakeryShoppingCart.DTOS;
using BakeryShoppingCart.Models;

namespace BakeryShoppingCart
{
    class Program
    {
        static void Main()
        {
            string response = "";
            List<User> userList = new List<User>();
            List<Comments> CommentList = new List<Comments>();

            while (response != "5")
            {
                Console.WriteLine("1. Create a user");
                Console.WriteLine("2. Create a Comment");
                Console.WriteLine("3. Print the list of Users");
                Console.WriteLine("4. Print the list if Comments");
                Console.WriteLine("5. Exit");

                Console.WriteLine("");
                Console.WriteLine("Please select an option");
                response = Console.ReadLine();

                switch(response)
                {
                    case "1":
                        User user = new User();
                        user.Email = "myemail@somehwere.com";
                        user.Password = "password";
                        user.UserId = 1;
                        user.UserName = "Cory";

                        userList.Add(user);

                        Console.WriteLine("You have craeted a user");
                        break;
                    case "2":
                        Comments myComment = new Comments();
                        myComment.CommentId = 1;
                        myComment.TheComment = "Hello";
                        CommentList.Add(myComment);
                        break;
                    case "3":
                        Console.WriteLine("This is the list of users created:");
                        foreach(var insideUser in userList)
                        {
                            Console.WriteLine("The user email is: " + insideUser.Email);
                            Console.WriteLine("The user password is: " + insideUser.Password);
                            Console.WriteLine("The user id is: " + insideUser.UserId);
                            Console.WriteLine("The user name is: " + insideUser.UserName);
                        }
                        break;
                    case "4":
                        Console.WriteLine("This is the list of comments craeted");
                        foreach (var insideComment in CommentList)
                        {
       
                            Console.WriteLine("The comment id is: " + insideComment.CommentId);
                            Console.WriteLine("The actual comment is: " + insideComment.TheComment);
                        }
                        Console.WriteLine("You have craeted a Comment");
                        break;
                }
            }

        }
    }
}
