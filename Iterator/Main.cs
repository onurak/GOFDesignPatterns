using System.Collections.Generic;

namespace DesignPatterns.Iterator
{
    internal class Main
    {
        public static void Test()
        {
            var collection = new ConcreteAggregate<string>
              {
                "Item 0", "Item 1", "Item 2", "Item 3", "Item 4"
              };

            IEnumerator<string> enumerator = collection.GetEnumerator();
        }
    }
}