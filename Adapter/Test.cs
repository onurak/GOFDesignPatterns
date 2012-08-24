namespace DesignPatterns.Adapter
{
    internal class Main
    {
        public static void Test()
        {
            var target = new Target();
            target.Request();

            Target adapter = new Adapter();
            adapter.Request();
        }
    }
}