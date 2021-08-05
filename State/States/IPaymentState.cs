using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public interface IPaymentState
    {
        public bool IsDelivered { get; set; }

 
        void DeliverOrder();
        bool CancelOrder();
        bool PaymentOrder();
    }
}
