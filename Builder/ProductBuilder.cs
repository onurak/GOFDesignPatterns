namespace DesignPatterns.Builder
{
    internal abstract class ProductBuilder
    {
        public Product product { get; private set; }

        public ProductBuilder(Enums.ProductType productType)
        {
            product = new Product(productType);
        }

        public abstract void BuildPartA();

        public abstract void BuildPartB();
    }
}