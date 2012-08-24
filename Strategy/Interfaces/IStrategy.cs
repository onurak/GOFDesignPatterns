using System.Collections.Generic;

namespace DesignPatterns.Strategy.Interfaces
{
    interface IStrategy
    {
        void Algorithm(IList<object> collection);
    }
}