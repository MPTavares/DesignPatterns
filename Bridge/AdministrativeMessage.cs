using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class AdministrativeMessage : IMessage
    {
        public ISenderTo Sender { get; set; }
        public string PhoneNumber { get; private set; }
        private readonly string _message;

        public AdministrativeMessage(string message)
        {
            _message = message;
        }
        public void Send()
        {
            if (Sender is null)
            {
                throw new ArgumentException("Sender must be defined.");
            }
            this.Sender.SendMessage(this);
        }

        public string FormattedMessage()
        {
            return $"Send message to administrative user with additional body: {_message}\n\n";
        }
    }
}
