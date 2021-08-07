using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Class
{
    class Car : IVehicle
    {
        public void Moving()
        {
            Console.WriteLine("I accelerate the car.");
        }

        public void Start()
        {
            Console.WriteLine("I start the car.");
        }

        public void Stop()
        {
            Console.WriteLine("I turn off the car.");
        }
    }
}
