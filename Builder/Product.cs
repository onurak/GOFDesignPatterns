using System.Collections.Generic;

namespace DesignPatterns.Builder
{
    internal class Product
    {
        private Enums.ProductType productType;
        private Dictionary<Enums.PartType, string> parts = new Dictionary<Enums.PartType, string>();

        // Constructor
        public Product(Enums.ProductType productType)
        {
            this.productType = productType;
        }

        public string this[Enums.PartType key]
        {
            get { return parts[key]; }
            set { parts[key] = value; }
        }
    }
}