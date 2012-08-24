using System.Collections.Generic;
using DesignPatterns.Command.Interfaces;

namespace DesignPatterns.Command
{
    internal class Invoker
    {
        private Receiver receiver = new Receiver();
        private List<ICommand> commands = new List<ICommand>();
        private int current = 0;

        public void Redo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (current < commands.Count - 1)
                {
                    commands[current++].Execute();
                }
            }
        }

        public void Undo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (current > 0)
                {
                    commands[--current].UnExecute();
                }
            }
        }

        public void Compute(object request)
        {
            ICommand command = new ConcreteCommand(receiver, request);
            command.Execute();

            commands.Add(command);
            current++;
        }
    }
}