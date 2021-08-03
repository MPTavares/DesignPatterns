using Strategy.Taxes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Classes
{
    public class TaxCalculator
    {
        public double Calculator(Budget budget, ITax tax)
        {
            return tax.Calculate(budget);
        }

    }
}
