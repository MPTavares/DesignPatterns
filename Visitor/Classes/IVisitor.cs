using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Classes
{
    public interface IVisitor
    {
        void ActionTeacher(Teacher teacher);
        void ActionStudent(Student student);
    }
}
