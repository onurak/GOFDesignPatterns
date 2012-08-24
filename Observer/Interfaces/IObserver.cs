using System;

namespace DesignPatterns.Observer.Interfaces
{
    interface IObserver
    {
        void Notify(object sender, EventArgs e);
    }
}