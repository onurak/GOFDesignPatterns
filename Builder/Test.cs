namespace DesignPatterns.Builder
{
    internal class Main
    {
        public static void Test()
        {
            var director = new Director();

            director.Construct(new ConcreteBuilder1());
            director.Construct(new ConcreteBuilder2());
        }
    }
}