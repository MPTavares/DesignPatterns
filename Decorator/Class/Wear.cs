using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Class
{
    public abstract class Wear : IHuman
    {
        protected IHuman human;
        public Wear(IHuman human)
        {
            this.human = human;
        }
        public abstract void PutOn();        
    }
}
