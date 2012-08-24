namespace DesignPatterns.Command
{
    internal class Main
    {
        public static void Test()
        {
            var invoker = new Invoker();

            invoker.Compute("request 1");
            invoker.Compute("request 1");
            invoker.Compute("request 1");
            invoker.Compute("request 1");

            invoker.Undo(1);
            invoker.Redo(2);
        }
    }
}