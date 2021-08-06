using Observer.Class;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Marcus Paulo", "email@company.com", "5511123456789");

            var emailObserver = new SendEmailObserver();
            var smsObserver = new SendSMSObserver();
            var whatsObserver = new SendEmailObserver();

            Console.WriteLine("\n\n-------- Send email to user --------");
            user.AttachObserver(emailObserver);
            user.ExecuteObserver();

            Console.WriteLine("\n\n-------- Send email,SMS and WhatsApp to user --------");
            user.AttachObserver(smsObserver);
            user.AttachObserver(whatsObserver);
            user.ExecuteObserver();

            Console.WriteLine("\n\n-------- Send SMS and WhatsApp to user --------");
            user.RemoveObserver(emailObserver);
            user.ExecuteObserver();

            Console.ReadLine();
        }
    }
}
