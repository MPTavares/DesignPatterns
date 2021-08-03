using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Classes
{
    class RedAlertTreatment : ErrorResponses
    {
        public override void ProcessErrorResponses(int errors)
        {
           if (errors > 15)
           {
                Console.WriteLine($"This is a red alert, because {errors} errors are reported.");
           }
        }
    }
}
