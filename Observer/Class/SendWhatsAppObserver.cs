using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Class
{
    class SendWhatsAppObserver : IObserver
    {
        public void Execute(Subject subject)
        {
            Console.WriteLine($"Simulate send WhatsApp message to {subject.CellPhone}");
        }
    }
}
