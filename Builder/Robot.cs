using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Robot
    {
        public string Name { get; set; }
        public string PrimaryFunction { get; set; }
        public List<string> Parts { get; set; } = new List<string>();

        public void Diagnostics()
        {
            Console.WriteLine($"Hi, my droid name is {this.Name}");
            Console.WriteLine($"I am a droid for {this.PrimaryFunction}");
            Console.WriteLine("This is my parts:");
            foreach(var part in Parts)
            {
                Console.WriteLine($" --> {part}");
            }
        }
    }
}
