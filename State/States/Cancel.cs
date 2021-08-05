using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    class Cancel : IPaymentState
    {
        public bool IsDelivered { get; set; }
        public bool CancelOrder()
        {
           Console.WriteLine("Order already canceled");
           return false;
        }

        public void DeliverOrder()
        {
            Console.WriteLine("Canceled order cannot be delivered.");
        }

        public bool PaymentOrder()
        {
            Console.WriteLine("Canceled order cannot be paid.");
            return false;
        }
    }
}
