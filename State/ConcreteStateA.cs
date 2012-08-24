namespace DesignPatterns.State
{
    internal class ConcreteStateA : State
    {
        public override void Handle()
        {
            this.context.State = new ConcreteStateB();
        }

        public override void Operation()
        {
            //
            this.Handle();
        }
    }
}