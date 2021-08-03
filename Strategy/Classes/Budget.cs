using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Classes
{
    public class Budget
    {
        public double Value { get; private set; }
        public string Name { get; private set; }
        public Budget(string name,double value)
        {
            this.Name = name;
            this.Value = value;
        }        
    }
}
