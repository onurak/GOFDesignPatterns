namespace DesignPatterns.Visitor
{
    internal class Main
    {
        public static void Test()
        {
            var os = new ObjectStructure();
            os.Attach(new ConcreteElementA());
            os.Attach(new ConcreteElementB());

            os.Accept(new ConcreteVisitorA());
            os.Accept(new ConcreteVisitorB());
        }
    }
}