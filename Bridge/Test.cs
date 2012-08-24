namespace DesignPatterns.Bridge
{
    internal class Main
    {
        public static void Test()
        {
            var refinedAbstraction = new RefinedAbstraction();
            refinedAbstraction.implementor = new ConcreteImplementor();

            refinedAbstraction.Operation();
        }
    }
}