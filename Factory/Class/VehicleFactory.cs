using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Class
{
    public class VehicleFactory
    {
        public IVehicle GetVehicle(Type vehicleType)
        {
            IVehicle vehicle = (IVehicle)Activator.CreateInstance(vehicleType);
            return vehicle;
        }
    }
}
