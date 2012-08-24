using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory
{
    internal class ConcreteFactory : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA();
        }

        public IProductB CreateProductB()
        {
            return new ProductB();
        }
    }
}