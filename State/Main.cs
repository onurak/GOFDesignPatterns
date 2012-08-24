namespace DesignPatterns.State
{
    internal class Main
    {
        public static void Test()
        {
            var context = new ConcreteStateA();

            // state a
            context.Operation();
            // state b
            context.Operation();
            // state a
        }
    }
}