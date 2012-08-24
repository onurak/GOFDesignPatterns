using System.Collections.Generic;

namespace DesignPatterns.Interpreter
{
    internal class Main
    {
        public static void Test()
        {
            var expressionList = new List<AbstractExpression>
            {
                new TerminalExpressionA(),
                new TerminalExpressionB()
            };

            var context = new Context();

            expressionList.ForEach(e => e.Interpret(context));
        }
    }
}