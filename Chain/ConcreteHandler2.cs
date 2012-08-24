using System;

namespace DesignPatterns.Chain
{
    internal class ConcreteHandler2 : Handler
    {
        public override void OperationHandler(object sender, EventArgs e)
        {
            if (Successor != null)
            {
                Successor.OperationHandler(this, e);
            }
            else
            {
                // request is handled if no successor
            }
        }
    }
}