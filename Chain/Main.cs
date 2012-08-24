namespace DesignPatterns.Chain
{
    internal class Main
    {
        public static void Test()
        {
            Handler concreteHandler1 = new ConcreteHandler1();
            Handler concreteHandler2 = new ConcreteHandler2();
            Handler concreteHandler3 = new ConcreteHandler3();

            concreteHandler1.Successor = concreteHandler2;
            concreteHandler2.Successor = concreteHandler3;

            concreteHandler1.ProcessRequest(new object());
        }
    }
}