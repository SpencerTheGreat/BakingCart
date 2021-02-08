using System;
namespace BakeryShoppingCart.Repositories.Implementation
{
    public class CommentRepository : MainRepository<Comment>, ICommentrpository
    {
        public CommentRepository()
        {
        }

        public void GetAllComments()
        {
            if (currentDatabase.Count > 0)
            
            {
                Console.WriteLine("Here are all the comments on the database");

                foreach (var comment in currentDatabase)
                {
                    Console.WriteLine(comment.CommentId);
                    Console.WriteLine(comment.TheComment);
                }
            }
            else
            {
                Console.WriteLine("There are no comments on the database");
            }
        }
    }

}