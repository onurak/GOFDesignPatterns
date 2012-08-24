namespace DesignPatterns.Prototype
{
    internal class Main
    {
        public static void Test()
        {
            var shallowCopy = new ConcretePrototype().Clone(true);
            var deepCopy = new ConcretePrototype().Clone(false);
        }
    }
}