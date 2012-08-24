namespace DesignPatterns.Factory
{
    internal abstract class Product
    {
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}