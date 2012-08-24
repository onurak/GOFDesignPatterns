using System;
using DesignPatterns.Observer.Interfaces;

namespace DesignPatterns.Observer
{
    internal class ConcreteObserver : IObserver
    {
        protected string ID;

        public ConcreteObserver(string ID)
        {
            this.ID = ID;
        }

        public void Notify(object sender, EventArgs e)
        {
            // this.ID notified
        }
    }
}