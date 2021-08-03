using Strategy.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Taxes
{
    public interface ITax
    {
        public double Calculate(Budget budget);
    }
}
