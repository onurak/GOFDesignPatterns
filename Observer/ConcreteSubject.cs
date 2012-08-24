namespace DesignPatterns.Observer
{
    internal class ConcreteSubject : Subject
    {
        public ConcreteSubject(object state)
        {
            base.State = state;
        }
    }
}