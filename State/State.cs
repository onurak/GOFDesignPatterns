namespace DesignPatterns.State
{
    internal abstract class State
    {
        public Context context { get; set; }

        public abstract void Operation();

        public abstract void Handle();
    }
}