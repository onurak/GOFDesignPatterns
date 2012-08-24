using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Iterator
{
    internal class ConcreteAggregate<T> : IEnumerable<T>
    {
        private List<T> items = new List<T>();

        public void Add(T t)
        {
            items.Add(t);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < items.Count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}