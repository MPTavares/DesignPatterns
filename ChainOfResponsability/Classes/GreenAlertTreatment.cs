using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Classes
{
    class GreenAlertTreatment : ErrorResponses
    {
        public override void ProcessErrorResponses(int errors)
        {
            if (errors <= 5)
            {
                Console.WriteLine($"This is a green alert, because only {errors} errors are reported.");
            }
            Successor?.ProcessErrorResponses(errors);
        }
    }
}
