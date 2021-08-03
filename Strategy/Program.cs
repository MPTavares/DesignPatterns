using Strategy.Classes;
using Strategy.Taxes;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strategy - Simple example of application of the Strategy design pattern.


            Budget budget = new Budget("Computer XYZ", 1000);
            TaxCalculator calculator = new TaxCalculator();

            ITax[] taxes = new ITax[]
            {
                new ISS(),
                new ICMS()
            };
            //Call Calculator to perform some additional action if necessary. In this example the Calculator class is quite simple.
            foreach (var tax in taxes)
            {
                Console.WriteLine($"Tax {tax.GetType().Name} calculated: {calculator.Calculator(budget, tax)}");
            }

            //Directly call the tax to present the calculation amount.
            foreach (var tax in taxes)
            {
                Console.WriteLine($"Tax {tax.GetType().Name} calculated: {tax.Calculate(budget)}");
            }

            Console.ReadLine();
        }
    }
}
