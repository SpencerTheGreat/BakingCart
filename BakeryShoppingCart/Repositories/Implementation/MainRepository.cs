using System;
using System.Collections.Generic;

namespace BakeryShoppingCart.Repositories.Implementation
{
    public class MainRepository<T> : IMainRepository<T>
    {

        public List<T> currentDatabase = new List<T>();

        public MainRepository()
        {
        }

        public void Delete(T entity)
        {
            currentDatabase.Remove(entity);
            //Console.WriteLine("You deleted the entity");//
        }

        public void Save(T entity)
        {
            currentDatabase.Add(entity);
        }

        public void Update(T entity)
        {
            //currentDatabase.Add(entity);//
            Console.WriteLine("You updated the entity");
        }
    }
}
