using DesignPatterns.Bridge.Interfaces;

namespace DesignPatterns.Bridge
{
    internal class Abstraction
    {
        public IImplementor implementor { get; set; }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }
}