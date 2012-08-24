using System;

namespace DesignPatterns.Chain
{
    internal abstract class Handler
    {
        public EventHandler<EventArgs> Operation;

        public abstract void OperationHandler(object sender, EventArgs e);

        public Handler()
        {
            Operation += OperationHandler;
        }

        public void ProcessRequest(object request)
        {
            OnRequest(new EventArgs());
        }

        public virtual void OnRequest(EventArgs e)
        {
            if (Operation != null)
            {
                Operation(this, e);
            }
        }

        public Handler Successor { get; set; }
    }
}