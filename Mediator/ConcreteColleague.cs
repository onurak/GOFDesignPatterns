namespace DesignPatterns.Mediator
{
    internal class ConcreteColleague : AbstractColleague
    {
        public override void Receive(string from, string message)
        {
            base.Receive(from, message);
        }
    }
}