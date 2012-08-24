using System.Collections.Generic;

namespace DesignPatterns.Factory
{
    internal abstract class Creator
    {
        public Creator()
        {
            this.CreateProducts();
        }

        public List<Product> Products { get; protected set; }

        public abstract void CreateProducts();

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}