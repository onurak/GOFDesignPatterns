using System;
using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    internal class Composite<T> where T : IComparable<T>
    {
        private List<Composite<T>> children = new List<Composite<T>>();

        public Composite<T> Add(T child)
        {
            var newNode = new Composite<T> { Node = child };
            children.Add(newNode);
            return newNode;
        }

        public void Remove(T child)
        {
            foreach (var treeNode in children)
            {
                if (treeNode.Node.CompareTo(child) == 0)
                {
                    children.Remove(treeNode);
                    return;
                }
            }
        }

        public T Node { get; set; }

        public List<Composite<T>> Children
        {
            get { return children; }
        }
    }
}