namespace DesignPatterns.Mediator
{
    internal class AbstractColleague
    {
        public string ID { get; set; }

        public ConcreteMediator concreteMediator { get; set; }

        public void Send(string ID, string message)
        {
            concreteMediator.Send(this.ID, ID, message);
        }

        public virtual void Receive(string ID, string message)
        {
            // this.ID has received message from ID
        }
    }
}