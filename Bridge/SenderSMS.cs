using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class SenderSMS : ISenderTo
    {
        public void SendMessage(IMessage message)
        {
            Console.WriteLine("Send SMS message");
            Console.WriteLine($"{message.FormattedMessage()}");
        }
    }
}
