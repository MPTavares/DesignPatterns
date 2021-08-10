namespace Interpreter
{
    public class Expression : IExpression
    {
        private bool expression;

        public Expression(bool expression)
        {
            this.expression = expression;
        }

        public bool Interpret()
        {
            return expression;
        }
    }
}