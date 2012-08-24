namespace DesignPatterns.Command.Interfaces
{
    interface ICommand
    {
        void Execute();

        void UnExecute();
    }
}