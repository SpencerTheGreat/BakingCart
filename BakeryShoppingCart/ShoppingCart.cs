using System;
using System.Collections.Generic;
using System.Linq;
using BakeryShoppingCart.Exceptions;
using BakeryShoppingCart.Models;

namespace BakeryShoppingCart
{

    public class ShoppingCart
    {
        private List<User> userList = new List<User>();
        private List<Comments> cakeReviewList = new List<Comments>();

        public ShoppingCart()
        {
        }

        public void PrintMenu()
        {
            Console.WriteLine("1. Create a User");
            Console.WriteLine("2. Create a Comments");
            Console.WriteLine("3. Print the list of Users");
            Console.WriteLine("4. Print the list of Comments");
            Console.WriteLine("5. Look for a User");
            Console.WriteLine("6. Look for a Comments");
            Console.WriteLine("7. Exit");
        }

        public string CaptureResponse()
        {
            string response = Console.ReadLine();

            return response;
        }

        public void CreateUser()
        {
            User myUser = new User();
            myUser.Email = "myemail@somewhere.com";
            myUser.Password = "Password";
            myUser.UserId = 1;
            myUser.UserName = "Mario";

            userList.Add(myUser);

            Console.WriteLine("");
            Console.WriteLine("You have created a User for your Shopping Cart");
            Console.WriteLine("");
        }

        public void CreateCakeReview()
        {
            Comments review = new Comments();
            review.ImagePath= "This is it";
            review.CommentId = 1;
           

            cakeReviewList.Add(review);

            Console.WriteLine("");
            Console.WriteLine("You have added a review for a Cake on your Shopping Cart");
            Console.WriteLine("");
        }

        public void ShowAllExistingUsers()
        {
            int userCount = 1;

            string format = "User {0}: Has the following data.- User Name[{1}], Password[{2}], " +
                            "UserId[{3}], Email[{4}]";

            Console.WriteLine("");
            foreach (var user in userList)
            {
                Console.WriteLine(String.Format(format, userCount, user.UserName, user.Password,
                                                user.UserId, user.Password));

                userCount++;
            }
            Console.WriteLine("");
        }

        public void ShowAllExistingCakeReviews()
        {
            int reviewCount = 1;

            string format = "Cake Review {0}: Has the following data.- Review belings to cake id[{1}], " +
                            "ReviewId[{2}], The Actual review[{3}]";

            Console.WriteLine("");
            foreach (var review in cakeReviewList)
            {
                Console.WriteLine(String.Format(format, reviewCount, review.CakeId, review.CommentId,
                                                review.ImagePath));

                reviewCount++;
            }
            Console.WriteLine("");
        }

        public void LookForAUser()
        {
            Console.WriteLine("");
            Console.WriteLine("Type the name of the user you are looking for.");
            string userName = Console.ReadLine();

            IList<User> usersFoundList = userList.Where(user => user.UserName.Contains(userName)).ToList();

            if (usersFoundList.Count == 0)
            {
                throw new UserNotFound("The user name specified was not found in the existing user list");
            }
            else
            {
                Console.WriteLine("These are all the users found with the user name requested:");

                foreach (var user in usersFoundList)
                {
                    Console.WriteLine(user.ToString());
                }

                Console.WriteLine("");
            }
        }

        public void LookForComments()
        {
            Console.WriteLine("");
            Console.WriteLine("Type a text you want to look for in the comments.");
            string review = Console.ReadLine();

            IList<Comments> cakeReviewsFoundList = cakeReviewList.Where(user => user.ImagePath.Contains(review)).ToList();

            if (cakeReviewsFoundList.Count == 0)
            {
                throw new CommentsNotFound("The comment review was not found in the existing cake review list");
            }
            else
            {
                Console.WriteLine("These are all the cake reviews found that contains the text requested:");

                foreach (var cakeReview in cakeReviewsFoundList)
                {
                    Console.WriteLine(cakeReview.ToString());
                }

                Console.WriteLine("");
            }
        }

        public void ExecuteMainMenu()
        {
            string response = "";

            while (response != "7")
            {
                PrintMenu();

                response = CaptureResponse();

                switch (response)
                {
                    case "1":
                        CreateUser();
                        break;
                    case "2":
                        CreateCakeReview();
                        break;
                    case "3":
                        ShowAllExistingUsers();
                        break;
                    case "4":
                        ShowAllExistingCakeReviews();
                        break;
                    case "5":
                        LookForAUser();
                        break;
                    case "6":
                        LookForComments();
                        break;
                }
            }
        }
    }
}

