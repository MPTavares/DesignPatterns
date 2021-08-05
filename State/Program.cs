using State.Class;
using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First scenario\n");
            Order firstOrder = new Order(500);
            Console.WriteLine($"Actual state -> {firstOrder.State.GetType().Name}");
            firstOrder.Deliver();
            Console.WriteLine($"Actual state -> {firstOrder.State.GetType().Name}");
            firstOrder.Payment();
            Console.WriteLine($"Actual state -> {firstOrder.State.GetType().Name}");
            firstOrder.Cancel();
            Console.WriteLine($"Actual state -> {firstOrder.State.GetType().Name}");

            Console.WriteLine("\n\nSecond scenario\n");
            Order secondOrder = new Order(500);
            Console.WriteLine($"Actual state -> {secondOrder.State.GetType().Name}");
            secondOrder.Payment();
            Console.WriteLine($"Actual state -> {secondOrder.State.GetType().Name}");
            secondOrder.Deliver();
            Console.WriteLine($"Actual state -> {secondOrder.State.GetType().Name}");
            secondOrder.Deliver();
            Console.WriteLine($"Actual state -> {secondOrder.State.GetType().Name}");
            Console.ReadLine();
        }
    }
}
