using System.Collections.Generic;
using DesignPatterns.Mediator.Interfaces;

namespace DesignPatterns.Mediator
{
    internal class ConcreteMediator : IMediator
    {
        private Dictionary<string, AbstractColleague> colleagues =
            new Dictionary<string, AbstractColleague>();

        public void Register(AbstractColleague colleague)
        {
            if (!colleagues.ContainsKey(colleague.ID))
            {
                colleagues.Add(colleague.ID, colleague);
            }

            colleague.concreteMediator = this;
        }

        public void Send(string from, string to, string message)
        {
            var participant = colleagues[to];
            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }
}