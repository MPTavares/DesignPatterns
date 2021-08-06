using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Class
{
    class User : Subject
    {
        public User(string name,string email,string cellPhone)
        {
            this.Name = name;
            this.Email = email;
            this.CellPhone = cellPhone;
        }
    }
}
