using System.Collections.Generic;

namespace DesignPatterns.Factory
{
    internal class ConcreteCreatorB : Creator
    {
        public override void CreateProducts()
        {
            Products = new List<Product> { new ConcreteProduct1(), new ConcreteProduct2() };
        }
    }
}