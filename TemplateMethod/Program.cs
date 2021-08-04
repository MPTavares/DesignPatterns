using System;
using TemplateMethod.Class;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------- Welcome Email -----------------------");

            TemplateEmailAbstract welcomeEmail = new WelcomeEmailConcrete("name 1", "test@test1.com", "server1");
            welcomeEmail.Send();

            Console.WriteLine("\n\n--------------------- Newsletter Email -----------------------");

            TemplateEmailAbstract newsLetterEmail = new NewsLetterEmailConcrete("name 1", "test@test1.com", "server1");
            newsLetterEmail.Send();

            Console.ReadKey();
        }
    }
}
