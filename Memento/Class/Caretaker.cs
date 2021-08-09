using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Class
{
    public class Caretaker
    {
        private IList<State> _listMemento = new List<State>();
        private Production _production;

        public Caretaker(Production production)
        {
            _production = production;
            SaveState();
        }
        public void SaveState()
        {
            _listMemento.Add(this._production.GetState());
        }
        public void UndoState()
        {
            if (this._listMemento.Count == 0) return;

            var memento = this._listMemento.Last();
            this._listMemento.Remove(memento);
            _production.RestoreState(memento);
        }

        public void HistoryState()
        {
            foreach(var state in _listMemento)
            {
                Console.WriteLine($"{state.DateState} - Name: ({state.Name}) - IsActive:{state.IsActive}");
            }
        }
    }
}
