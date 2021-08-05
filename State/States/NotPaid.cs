using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    class NotPaid : IPaymentState
    {
        public bool IsDelivered { get; set; }

        public bool CancelOrder()
        {
            Console.WriteLine("Canceled order!");
            return true;
        }

        public void DeliverOrder()
        {
            Console.WriteLine("Orders without payment cannot be delivered.");
        }

        public bool PaymentOrder()
        {
            Console.WriteLine("Payment processed");
            return true;
        }
    }
}
