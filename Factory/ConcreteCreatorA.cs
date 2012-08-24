using System.Collections.Generic;

namespace DesignPatterns.Factory
{
    internal class ConcreteCreatorA : Creator
    {
        public override void CreateProducts()
        {
            Products = new List<Product> { new ConcreteProduct1() };
        }
    }
}