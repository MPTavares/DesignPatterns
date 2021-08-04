using Decorator.Class;
using System;
using System.Reflection;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {           
          
            Console.WriteLine("Dress a person for winter.");
            Console.WriteLine("-----------------------------------------");
            IHuman dressPersonToWinter = new Human();

            dressPersonToWinter = new TShirt(dressPersonToWinter);
            dressPersonToWinter = new Sueter(dressPersonToWinter);
            dressPersonToWinter = new Jacket(dressPersonToWinter);          
             
            dressPersonToWinter.PutOn();


            Console.WriteLine("\n\nDress a person for summer.");
            Console.WriteLine("-----------------------------------------");
            IHuman dressPersonToSummer = new Human();

            dressPersonToSummer = new TShirt(dressPersonToSummer);
            dressPersonToSummer.PutOn();

            Console.ReadKey();
        }
    }
}
