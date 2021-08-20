using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class SenderEmail : ISenderTo
    {
        public void SendMessage(IMessage message)
        {
            Console.WriteLine("Send Email message");
            Console.WriteLine($"{message.FormattedMessage()}");
        }
    }
}
