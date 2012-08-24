namespace DesignPatterns.Composite
{
    internal class Main
    {
        public static void Test()
        {
            var root = new Composite<Component> { Node = new Component("Component A") };

            root.Add(new Component("Component A - 1"));
            root.Add(new Component("Component A - 2"));
            root.Add(new Component("Component A - 3"));
        }
    }
}