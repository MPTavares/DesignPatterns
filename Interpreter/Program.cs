using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpression firstExpression = new AndExpression(new Expression(true), new Expression(false));
            Console.WriteLine($"First expression: {firstExpression.Interpret()}");

            IExpression secondExpression = new OrExpression(new Expression(true), new Expression(true));
            Console.WriteLine($"\nSecond expression: {secondExpression.Interpret()}");

            IExpression thirdExpression = new AndExpression(firstExpression, secondExpression);
            Console.WriteLine($"\nThird expression: {thirdExpression.Interpret()}");

            Console.ReadLine();
        }
    }
}
