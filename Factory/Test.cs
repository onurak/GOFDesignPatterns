using System.Collections.Generic;

namespace DesignPatterns.Factory
{
    internal class Main
    {
        public static void Test()
        {
            var products = new List<Creator> { new ConcreteCreatorA(), new ConcreteCreatorB() };
        }
    }
}