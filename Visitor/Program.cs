using System;
using Visitor.Classes;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Alice", "alice@school.com");
            var teacher = new Teacher("Sam", "Sam@school.com");

            SendMail mail = new SendMail();
            SendSMS sms = new SendSMS();

            student.accept(mail);
            teacher.accept(mail);

            student.accept(sms);
            teacher.accept(sms);

            Console.ReadKey();
        }
    }
}
