using DesignPatterns.Visitor.Interfaces;

namespace DesignPatterns.Visitor
{
    internal class ConcreteVisitorA : Visitor
    {
        public void Visit(ConcreteElementA concreteElementA)
        {
            DoVisit(concreteElementA);
        }

        public void Visit(ConcreteElementB concreteElementB)
        {
            DoVisit(concreteElementB);
        }

        private void DoVisit(IElement element)
        {
            var concreteElement = element as ConcreteElement;
        }
    }
}