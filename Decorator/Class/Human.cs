using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Class
{
    public class Human : IHuman
    {
        public void PutOn()
        {
            Console.WriteLine("The person is wearing only pants and shoes.");
        }      
    }
}
