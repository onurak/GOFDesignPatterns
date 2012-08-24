namespace DesignPatterns.Mediator.Interfaces
{
    interface IMediator
    {
        void Send(string from, string to, string message);
    }
}