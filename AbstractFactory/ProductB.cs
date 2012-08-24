using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory
{
    internal class ProductB : IProductB
    {
        public void Interact(IProductA productA)
        {
            // Product B interacts with Product A
        }
    }
}