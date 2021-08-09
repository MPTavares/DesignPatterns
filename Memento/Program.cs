using Memento.Class;
using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Production production = new Production("Marcus", true);
            Console.WriteLine("-------- Create and save initial state --------");
            
            Caretaker caretaker = new Caretaker(production);
            production.ShowState();
            Console.WriteLine("\n\n-------- Change name and save state -----------");
            production.SetName("Marcus Paulo Tavares");
            production.ShowState();
            caretaker.SaveState();
            Console.WriteLine("\n\n------ Change name and not save state ----------");
            production.SetName("type wrong");
            production.ShowState();
            Console.WriteLine("\n\n------------- Show history  -------------------");
            caretaker.HistoryState();
            Console.WriteLine("\n\n-------------- Undo state  --------------------");
            caretaker.UndoState();
            production.ShowState();
            Console.WriteLine("\n\n----- Undo state and return to inital state ----");
            caretaker.UndoState();
            production.ShowState();

            Console.ReadKey();
        }
    }
}
