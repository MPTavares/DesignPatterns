namespace Visitor.Classes
{
    public class Teacher : IPeople
    {
        public string Name { get; private set; }
        public string Email { get; private set; }

        public Teacher(string name,string email)
        {
            this.Name = name;
            this.Email = email;
        }

        public void accept(IVisitor visitor)
        {
            visitor.ActionTeacher(this);
        }
    }
}