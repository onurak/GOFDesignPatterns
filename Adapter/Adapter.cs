namespace DesignPatterns.Adapter
{
    internal class Adapter : Target
    {
        private Adaptee adaptee;

        public Adapter()
        {
            adaptee = new Adaptee();
        }

        public override void Request()
        {
            adaptee.Request();
        }
    }
}