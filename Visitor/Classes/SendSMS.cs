using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Classes
{
    class SendSMS : IVisitor
    {
        public void ActionStudent(Student student)
        {
            Console.WriteLine($"Send SMS to student {student.Email}");
        }

        public void ActionTeacher(Teacher teacher)
        {
            Console.WriteLine($"Send SMS to teacher {teacher.Email}");
        }
    }
}
