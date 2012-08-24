namespace DesignPatterns.State
{
    internal class ConcreteStateB : State
    {
        public override void Handle()
        {
            this.context.State = new ConcreteStateA();
        }

        public override void Operation()
        {
            //
            this.Handle();
        }
    }
}