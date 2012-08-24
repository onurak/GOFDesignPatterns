namespace DesignPatterns.Decorator
{
    internal abstract class Component
    {
        public static object property { get; set; }

        public abstract void Operation();
    }
}