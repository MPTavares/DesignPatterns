using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Classes
{
    public abstract class ErrorResponses
    {
        protected ErrorResponses Successor;
        public void SetSucessor(ErrorResponses errorRequestsSuccessor)
        {
            Successor = errorRequestsSuccessor;
        }        

        public abstract void ProcessErrorResponses(int errors);
    }
}
