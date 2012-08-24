using System.Collections.Generic;
using DesignPatterns.Bridge.Interfaces;

namespace DesignPatterns.Bridge
{
    internal class ConcreteImplementor : IImplementor
    {
        private List<object> objects;

        public ConcreteImplementor()
        {
            objects = new List<object>();
        }

        public void Operation()
        {
        }
    }
}