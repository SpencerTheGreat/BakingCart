using System;
using System.Collections.Generic;
using System.Linq;
using BakeryShoppingCart.Exceptions;

namespace BakeryShoppingCart.Repositories.Implementation
{
    public class CakeRepository : MainRepository<Cake>, ICake_Repository
    {
        public CakeRepository()
        {
        }

        public void GetAllChocolateCakes()
        {
            List<Cake> resultList =
             currentDatabase.Where(cake => cake.Flavor == "Chocolate").ToList();

            if (resultList.Count > 0)
            {
                foreach(var cake in resultList)
                {
                    Console.WriteLine(cake.CakeId);
                    Console.WriteLine(cake.Flavor);
                    Console.WriteLine(cake.Type);

                }
            }
            else
            {
                throw new CakeNotFound("No chocolate cakes found");
            }
        }
    }
}
