using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface IMessage
    {
        ISenderTo Sender { get; set; }
        void Send();
        string FormattedMessage();
    }
}
