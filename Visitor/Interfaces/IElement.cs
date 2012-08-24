namespace DesignPatterns.Visitor.Interfaces
{
    public interface IElement
    {
        void Accept(Visitor visitor);
    }
}