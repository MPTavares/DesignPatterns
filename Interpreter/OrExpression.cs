namespace Interpreter
{
    internal class OrExpression : IExpression
    {
        private IExpression expression1;
        private IExpression expression2;

        public OrExpression(IExpression expression1, IExpression expression2)
        {
            this.expression1 = expression1;
            this.expression2 = expression2;
        }

        public bool Interpret()
        {
            return expression1.Interpret() || expression2.Interpret();
        }
    }
}