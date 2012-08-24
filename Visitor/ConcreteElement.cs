using DesignPatterns.Visitor.Interfaces;

namespace DesignPatterns.Visitor
{
    internal class ConcreteElement : IElement
    {
        public void Accept(Visitor visitor)
        {
            visitor.ReflectiveVisit(this);
        }
    }
}