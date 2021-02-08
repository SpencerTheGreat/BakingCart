using System;
namespace BakeryShoppingCart.Repositories.Implementation
{
    public interface ICommentrpository : IMainRepository<Comment>
    {
        
      
            public void GetAllComments();
        }
    }

