namespace Visitor.Classes
{
    public interface IPeople
    {
        void accept(IVisitor visitor);
    }
}