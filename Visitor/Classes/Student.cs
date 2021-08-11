namespace Visitor.Classes
{
    public class Student :IPeople
    {
        public string Name { get; private set; }
        public string Email { get; private set; }

        public Student(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }

        public void accept(IVisitor visitor)
        {
            visitor.ActionStudent(this);
        }
    }
}