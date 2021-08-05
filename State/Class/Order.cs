using State.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Class
{
    public class Order
    {
        public double Value {get;private set;}
        public IPaymentState State { get; set; }

        public Order(double value)
        {
            this.Value = value;
            this.State = new NotPaid();
        }
        public void Deliver()
        {
            this.State.DeliverOrder();         
        }
        public void Cancel()
        {
            if (this.State.CancelOrder())
            {
                this.State = new Cancel();
            }
        }
        public void Payment()
        {
            if (this.State.PaymentOrder())
            {
                this.State = new Paid();
            }            
        }
    }
}
