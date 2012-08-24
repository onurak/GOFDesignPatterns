using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory
{
    internal class ProductA : IProductA
    {
        public void Interact(IProductB productB)
        {
            // Product A interacts with Product B
        }
    }
}