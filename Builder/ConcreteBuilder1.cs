namespace DesignPatterns.Builder
{
    internal class ConcreteBuilder1 : ProductBuilder
    {
        // Invoke base class constructor
        public ConcreteBuilder1()
            : base(Enums.ProductType.ProductType1)
        {
        }

        public override void BuildPartA()
        {
            product[Enums.PartType.PartTypeA] = "part a of product type 1";
        }

        public override void BuildPartB()
        {
            product[Enums.PartType.PartTypeB] = "part b of product type 1";
        }
    }
}