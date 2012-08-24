using System.Collections.Generic;

namespace DesignPatterns.Decorator
{
    internal class ConcreteDecorator : Decorator
    {
        private List<string> _borrowers = new List<string>();

        public ConcreteDecorator(Component component)
            : base(component)
        {
        }

        public void AnotherOperation()
        {
        }

        public override void Operation()
        {
            base.Operation();
        }
    }
}