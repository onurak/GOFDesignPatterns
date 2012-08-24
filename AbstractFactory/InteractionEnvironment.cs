using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory
{
    internal class InteractionEnvironment<T> : IInteractionEnvironment where T : IAbstractFactory, new()
    {
        private IProductA productA;
        private IProductB productB;
        private T factory;

        public InteractionEnvironment()
        {
            factory = new T();

            productA = factory.CreateProductA();
            productB = factory.CreateProductB();
        }

        public void InteractEach()
        {
            productA.Interact(productB);
            productB.Interact(productA);
        }
    }
}