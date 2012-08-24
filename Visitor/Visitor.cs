using System;
using DesignPatterns.Visitor.Interfaces;

namespace DesignPatterns.Visitor
{
    public abstract class Visitor
    {
        public void ReflectiveVisit(IElement element)
        {
            var types = new Type[] { element.GetType() };
            var mi = this.GetType().GetMethod("Visit", types);

            if (mi != null)
            {
                mi.Invoke(this, new object[] { element });
            }
        }
    }
}