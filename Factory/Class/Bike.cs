using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Class
{
    class Bike : IVehicle
    {
        public void Moving()
        {
            Console.WriteLine("I ride my bike");
        }

        public void Start()
        {
            Console.WriteLine("I sit on the bike");
        }

        public void Stop()
        {
            Console.WriteLine("I get of the bike");
        }
    }
}
