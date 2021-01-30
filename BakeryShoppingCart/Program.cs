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

            MyClass<string> newClass = new MyClass<string>();
            newClass.MyProperty1 = "Hop value";
            newClass.MyProperty2 = "Skip value";
            newClass.MyProperty3 = "Jump value";

            newClass.PrintSomething();
            newClass.PrintSomethingelse("Print This !!");

        }
     }
}

public class MyClass<T>

{
    public string MyProperty1 { get; set; }
    public T MyProperty2 { get; set; }
    public T MyProperty3 { get; set; }

        public void PrintSomething()

    {
        Console.WriteLine("This is an Action!");
    }

    public void PrintSomethingelse(T parameter1)

    {
        Console.WriteLine("The parameter value is the following: ");
    }

    internal void PrintSomethingelse()
    {
        throw new NotImplementedException();
    }
}