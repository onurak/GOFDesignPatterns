namespace DesignPatterns.State
{
    internal class Context
    {
        private State state;

        public Context(State state)
        {
            this.State = state;
        }

        public State State
        {
            get { return state; }
            set
            {
                state = value;
            }
        }
    }
}