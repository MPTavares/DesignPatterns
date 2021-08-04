using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Class
{
    public class WelcomeEmailConcrete : TemplateEmailAbstract
    {
        public WelcomeEmailConcrete(string name, string email, string smtpServer) : base(name, email, smtpServer)
        {

        }

        protected override string BodyContent()
        {
            return $"Welcome {name}";
        }

        protected override string BottomContent()
        {
            return "";
        }

      
    }
}
