using System;
using DesignPatterns.Observer.Interfaces;

namespace DesignPatterns.Observer
{
    internal abstract class Subject
    {
        public Subject()
        {
        }

        protected object state;

        public event EventHandler<EventArgs> Change;

        public virtual void OnChange(EventArgs e)
        {
            if (Change != null)
            {
                Change(this, e);
            }
        }

        public void Attach(IObserver observer)
        {
            Change += observer.Notify;
        }

        public void Detach(IObserver observer)
        {
            Change -= observer.Notify;
        }

        public object State
        {
            get { return state; }
            set
            {
                if (state != value)
                {
                    state = value;
                    OnChange(new EventArgs { });
                }
            }
        }
    }
}