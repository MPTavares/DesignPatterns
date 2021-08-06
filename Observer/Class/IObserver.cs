using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Class
{
    public interface IObserver
    {
        void Execute(Subject subject);
    }
}
