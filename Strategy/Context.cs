using System.Collections.Generic;
using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy
{
    internal class Context : List<object>
    {
        public IStrategy Strategy { get; set; }

        public Context(IStrategy strategy)
        {
            this.Strategy = strategy;
        }

        public void ApplyStrategy()
        {
            this.Strategy.Algorithm(this);
        }
    }
}