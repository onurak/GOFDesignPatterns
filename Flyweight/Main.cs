namespace DesignPatterns.Flyweight
{
    internal class Main
    {
        public static void Test()
        {
            var factory = new FlyweightFactory();
            var ConcreteFlyweight1 = factory[1];
            var ConcreteFlyweight2 = factory[2];
        }
    }
}