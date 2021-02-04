using System;
using System.Collections.Generic;
using System.Linq;
using BakeryShoppingCart.DTOS;
using BakeryShoppingCart.Models;

namespace BakeryShoppingCart
{
    class Program
    // try
    {
        //   ShoppingCart myShoppingCart = new ShoppingCart();

        //   myShoppingCart.ExecuteMainMenu();
    }

    //  catch (ShoppingCartException exception)
    // {
    // Console.WriteLine(exception.Message);
    // }

    private MyClass myVariable = new MyClass();
    myVariable.MyMethod<string>("string 1", "string 2");

            Console.WriteLine(myVariable.MyProperty1);
            Console.WriteLine(myVariable.MyProperty2);
        }
    }
}


public class MyClass
{
    public string MyProperty1 { get; set; }
    public string MyProperty2 { get; set; }

    public void MyMethod<T>(T parameter1, T parameter2)
    {
        this.MyProperty1 = parameter1.ToString();
        this.MyProperty2 = parameter2.ToString();
    }
}