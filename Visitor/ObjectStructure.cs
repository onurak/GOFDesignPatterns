using System.Collections.Generic;

namespace DesignPatterns.Visitor
{
    internal class ObjectStructure : List<ConcreteElement>
    {
        public void Attach(ConcreteElement concreteElement)
        {
            Add(concreteElement);
        }

        public void Detach(ConcreteElement concreteElement)
        {
            Remove(concreteElement);
        }

        public void Accept(Visitor visitor)
        {
            this.ForEach(employee => employee.Accept(visitor));
        }
    }
}