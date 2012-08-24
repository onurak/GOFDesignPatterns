using System;

namespace DesignPatterns.Composite
{
    internal class Component : IComparable<Component>
    {
        private object obj;

        public Component(object obj)
        {
            this.obj = obj;
        }

        public override string ToString()
        {
            return this.obj.ToString();
        }

        public int CompareTo(Component RHS)
        {
            return (this.obj == RHS.obj) ? 0 : -1;
        }
    }
}