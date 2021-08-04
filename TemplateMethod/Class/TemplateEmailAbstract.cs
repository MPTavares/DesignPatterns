using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Class
{
    public abstract class TemplateEmailAbstract
    {

        const string LineFeed = "\n";

        protected string name;
        protected string email;
        protected string smtp;
        
        public TemplateEmailAbstract(string name,string email,string smtpServer)
        {
            this.name = name;
            this.email = email;
            this.smtp = smtpServer;
        }
        public void Send()
        {
            var html = "";
            html += LineFeed + TopContent();
            html += LineFeed + BodyContent();
            html += LineFeed + BottomContent();
            html += LineFeed + FooterContent();

            Console.WriteLine($"To: {name}{LineFeed}E-mail: {email}{LineFeed}Smtp server: {smtp}");
            Console.WriteLine(html);
        }
        private string TopContent()
        {
            return LineFeed + "[Logo Company]";
        }
        protected abstract string BottomContent();
        protected abstract string BodyContent();
        protected virtual string FooterContent()
        {
            var html = "----------------------------------------------------------------";
            html += LineFeed + "Please, not reply this email. ";
            return html;
        }
    }
}
