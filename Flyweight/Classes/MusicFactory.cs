using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Classes
{
    class MusicFactory
    {
        private HashSet<Type> notesSet = new HashSet<Type>();

        public IMusicalNote getNote(Type note)
        {
            Type noteFounded;
            if (!notesSet.TryGetValue(note, out noteFounded))
            {
                notesSet.Add(note);
                noteFounded = note;
            }

            var noteCreated = (IMusicalNote) Activator.CreateInstance(noteFounded);

            return noteCreated;
        }
        public int GetObjects()
        {
            return notesSet.Count();
        }
    }
}
