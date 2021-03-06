﻿namespace DesignPatterns.Interpreter
{
    internal abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
}