namespace DesignPatterns.Template
{
    internal class Main
    {
        public static void Test()
        {
            AbstractClass constractClassA = new ConcreteClassA();
            constractClassA.Select();
            constractClassA.Process();

            AbstractClass constractClassB = new ConcreteClassB();
            constractClassB.Select();
            constractClassB.Process();
        }
    }
}