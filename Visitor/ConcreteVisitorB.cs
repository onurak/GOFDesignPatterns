using DesignPatterns.Visitor.Interfaces;

namespace DesignPatterns.Visitor
{
    internal class ConcreteVisitorB : Visitor
    {
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