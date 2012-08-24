namespace DesignPatterns.AbstractFactory.Interfaces
{
    interface IAbstractFactory
    {
        IProductA CreateProductA();

        IProductB CreateProductB();
    }
}