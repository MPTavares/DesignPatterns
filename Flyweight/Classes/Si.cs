using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Classes
{
    class Si : IMusicalNote
    {
        public void Play()
        {
            Console.Write("Do ");
        }
    }
}
