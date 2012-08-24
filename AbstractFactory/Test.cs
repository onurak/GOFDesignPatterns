namespace DesignPatterns.AbstractFactory
{
    internal class Main
    {
        public static void Test()
        {
            var environment = new InteractionEnvironment<ConcreteFactory>();
            environment.InteractEach();
        }
    }
}