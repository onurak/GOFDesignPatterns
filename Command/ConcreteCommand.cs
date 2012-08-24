using DesignPatterns.Command.Interfaces;

namespace DesignPatterns.Command
{
    internal class ConcreteCommand : ICommand
    {
        private object request;
        private Receiver receiver;

        public ConcreteCommand(Receiver receiver, object request)
        {
            this.request = request;
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.Execute(request);
        }

        public void UnExecute()
        {
            receiver.UnExecute(request);
        }
    }
}