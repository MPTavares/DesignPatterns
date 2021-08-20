using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {

            ISenderTo senderEmail = new SenderEmail();
            ISenderTo senderSMS = new SenderSMS();

            IMessage message = new AdministrativeMessage("We have a problem!");
            message.Sender = senderEmail;
            message.Send();

            message.Sender = senderSMS;
            message.Send();

            IMessage messagePromotion = new ClientMessage("We have a new promotion!");
            messagePromotion.Sender = senderEmail;
            messagePromotion.Send();

            Console.ReadLine();
        }
    }
}
