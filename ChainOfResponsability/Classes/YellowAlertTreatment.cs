using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Classes
{
    class YellowAlertTreatment : ErrorResponses
    {
        public override void ProcessErrorResponses(int errors)
        {
            if (errors > 5 && errors < 15)
            {
                Console.WriteLine($"This is a yellow alert, because {errors} errors are reported.");
            }
            Successor?.ProcessErrorResponses(errors);
        }
    }
}
