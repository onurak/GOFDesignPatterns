namespace DesignPatterns.Decorator
{
    internal class Main
    {
        public static void Test()
        {
            var concreteComponent = new ConcreteComponent("concrete property", "component property");
            concreteComponent.Operation();

            var concreteDecorator = new ConcreteDecorator(concreteComponent);
            concreteDecorator.AnotherOperation();
        }
    }
}