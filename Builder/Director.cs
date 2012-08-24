using System.Collections.Generic;

namespace DesignPatterns.Builder
{
    internal class Director
    {
        private List<ProductBuilder> productBuilderList = new List<ProductBuilder>();

        public void Construct(ProductBuilder productBuilder)
        {
            productBuilder.BuildPartA();
            productBuilder.BuildPartB();
            this.productBuilderList.Add(productBuilder);
        }
    }
}