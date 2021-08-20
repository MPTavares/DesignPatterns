using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class ClientMessage: IMessage
    {
        public string Email { get; private set; }
        public ISenderTo Sender { get; set; }

        private readonly string _message;

        public ClientMessage(string message)
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
            return $"Send message to client with additional body: {_message}\n\n";
        }
    }
}
