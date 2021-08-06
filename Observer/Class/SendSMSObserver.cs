using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Class
{
    class SendSMSObserver : IObserver
    {
        public void Execute(Subject subject)
        {
            Console.WriteLine($"Simulate send SMS message to {subject.CellPhone}");
        }
    }
}
