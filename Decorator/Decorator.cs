namespace DesignPatterns.Decorator
{
    internal abstract class Decorator : Component
    {
        private Component component;

        public Decorator(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            component.Operation();
        }
    }
}