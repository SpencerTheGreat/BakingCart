using System;
namespace BakeryShoppingCart.Repositories
{
    public interface ICake_Repository : IMainRepository<Cake>
    {
        public void GetAllChocolateCakes();
    }
}
