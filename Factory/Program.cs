using Factory.Class;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------- Creating a car --------------- ");
            IVehicle car = new VehicleFactory().GetVehicle(typeof(Car));
            car.Start();
            car.Moving();
            car.Stop();

            Console.WriteLine("\n\n-------------- Creating a bike --------------- ");
            IVehicle bike = new VehicleFactory().GetVehicle(typeof(Bike));
            bike.Start();
            bike.Moving();
            bike.Stop();

            Console.WriteLine("\n\n----------- Creating a car and a bike --------- ");
            Type[] array = { typeof(Car), typeof(Bike) };
            foreach(var type in array)
            {
                IVehicle vehicle = new VehicleFactory().GetVehicle(type);
                vehicle.Start();
                vehicle.Moving();
                vehicle.Stop();
            }

            Console.ReadKey();

        }
    }
}
