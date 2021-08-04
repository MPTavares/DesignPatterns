using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Class
{
    public class NewsLetterEmailConcrete : TemplateEmailAbstract
    {
        public NewsLetterEmailConcrete(string name, string email, string smtpServer) : base(name, email, smtpServer)
        {
        }

        protected override string BodyContent()
        {
            return $"Welcome {name}\nContent about this newsletter.";
        }

        protected override string BottomContent()
        {
            return $"\nSpecific content.";
        }
        protected override string FooterContent()
        {
            return $"\nTo unsubscribe from newsletters, click here";
        }

    }
}
