namespace DesignPatterns.Strategy
{
    internal class Main
    {
        public static void Test()
        {
            var records = new Context(new ConcreteStrategyA()) { "1", "2", "3", "4", "5" };
            records.ApplyStrategy();
            records.Strategy = new ConcreteStrategyB();
            records.ApplyStrategy();
        }
    }
}