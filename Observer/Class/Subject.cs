using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Class
{
    public abstract class Subject
    {
        public string Name { get; protected set; }
        public string Email { get; protected set; }
        public string CellPhone { get; protected set; }

        private List<IObserver> observerList = new List<IObserver>();

        public void AttachObserver(IObserver observer)
        {
            observerList.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observerList.Remove(observer);
        }
        public void ExecuteObserver()
        {
            foreach (var observer in observerList)
            {
                observer.Execute(this);
            }
        }
    }
}
