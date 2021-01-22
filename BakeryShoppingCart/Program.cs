using System;
using BakeryShoppingCart.Models;

namespace BakeryShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myFirstDateTimeVariable = new DateTime(2021, 01, 22);
            DateTime mySecondDateTimeVariable = new DateTime(2030, 05, 10);

            int result = DateTime.Compare(myFirstDateTimeVariable, mySecondDateTimeVariable);

            if (result == 1)
            {
                Console.WriteLine("The second date is greater");
            }
            else
            {
                Console.WriteLine("The first date is greater");
            }
                
        }
        
    
    }
}