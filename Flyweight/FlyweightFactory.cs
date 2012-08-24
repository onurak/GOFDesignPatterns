using System;
using System.Collections.Generic;

namespace DesignPatterns.Flyweight
{
    internal class FlyweightFactory
    {
        private Dictionary<int, Flyweight> flyweights =
                       new Dictionary<int, Flyweight>();

        public Flyweight this[int key]
        {
            get
            {
                Flyweight flyweight = null;
                if (flyweights.ContainsKey(key))
                {
                    flyweight = flyweights[key];
                }
                else
                {
                    string name = this.GetType().Namespace + "." +
                                     "ConcreteFlyweight" + key.ToString();
                    flyweight = (Flyweight)Activator.CreateInstance
                                     (Type.GetType(name));
                    this.flyweights.Add(key, flyweight);
                }

                return flyweight;
            }
        }
    }
}