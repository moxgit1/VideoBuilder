using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDrink();
        }

        private static void TestDrink()
        {
            var juice = new Juice("Orange", "made from oranges");
            var beer = new Beer( "Budweiser",  "5% alcohol");
            var soda = new Soda("Pepsi");
            
            var drinks = new List<Drink>(){juice, beer, soda };
            drinks.ForEach(dd => {
                Console.WriteLine(dd.Description());
            
            });
        }        
    
    }
}
