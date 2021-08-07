using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Classes
{
    class Do : IMusicalNote
    {
        public void Play()
        {
            Console.Write("Do ");
        }
    }
}
