using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    class Paid : IPaymentState
    {
        public bool IsDelivered { get; set; }
        public bool CancelOrder()
        {
            Console.WriteLine("Order canceled and payment returned.");
            return true;
        }

        public void DeliverOrder()
        {
            if (this.IsDelivered)
            {
                Console.WriteLine("Order has already been delivered.");
            } else
            {
                this.IsDelivered = true;
                Console.WriteLine("Orders shipped for delivery.");
            }            
        }

        public bool PaymentOrder()
        {
            Console.WriteLine("Payment already made.");
            return false;        
        }
    }
}
