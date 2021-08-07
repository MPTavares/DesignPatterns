using Flyweight.Classes;
using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Type[] music = { 
                typeof(Do), 
                typeof(Re), 
                typeof(Mi), 
                typeof(Fa), 
                typeof(Fa), 
                typeof(Fa),
                typeof(Do), 
                typeof(Re), 
                typeof(Do), 
                typeof(Re), 
                typeof(Re), 
                typeof(Re), 
                typeof(Sol), 
                typeof(Fa), 
                typeof(Mi),
                typeof(Mi),
                typeof(Mi),
                typeof(Do),
                typeof(Re),
                typeof(Mi),
                typeof(Fa),
                typeof(Fa),
                typeof(Fa),
                typeof(La),
                typeof(Si)
            };

            var musiceFactory = new MusicFactory();
            foreach (var note in music)
            {
                var noteToPlay = musiceFactory.getNote(note);
                noteToPlay.Play();
            }
            Console.WriteLine($"\nObjects created: {musiceFactory.GetObjects()}");
            Console.ReadKey();
        }
        
    }
}
