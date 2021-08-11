using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Classes
{
    public class SendMail : IVisitor
    {
        public void ActionStudent(Student student)
        {
            Console.WriteLine($"Send email to student {student.Email}");
        }

        public void ActionTeacher(Teacher teacher)
        {
            Console.WriteLine($"Send email to teacher {teacher.Email}");
        }
    }
}
