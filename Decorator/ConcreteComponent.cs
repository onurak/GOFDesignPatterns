namespace DesignPatterns.Decorator
{
    internal class ConcreteComponent : Component
    {
        private object concreteProperty;

        public ConcreteComponent(object concreteProperty, object componentProperty)
        {
            this.concreteProperty = concreteProperty;
            property = componentProperty;
        }

        public override void Operation()
        {
        }
    }
}