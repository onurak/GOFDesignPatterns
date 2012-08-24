using System;

namespace DesignPatterns.Adapter
{
    internal class Target
    {
        public Object obj { get; protected set; }

        public virtual void Request()
        {
        }
    }
}