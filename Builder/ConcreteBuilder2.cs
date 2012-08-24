namespace DesignPatterns.Builder
{
    internal class ConcreteBuilder2 : ProductBuilder
    {
        // Invoke base class constructor
        public ConcreteBuilder2()
            : base(Enums.ProductType.ProductType2)
        {
        }

        public override void BuildPartA()
        {
            product[Enums.PartType.PartTypeA] = "part a of product type 2";
        }

        public override void BuildPartB()
        {
            product[Enums.PartType.PartTypeB] = "part b of product type 2";
        }
    }
}