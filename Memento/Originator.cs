using System;

namespace DesignPatterns.Memento
{
    [Serializable]
    internal class Originator
    {
        private string state;

        public string State
        {
            get { return state; }
            set
            {
                state = value;
            }
        }

        public Memento SaveMemento()
        {
            var memento = new Memento();
            return memento.Serialize(this);
        }

        public void RestoreMemento(Memento memento)
        {
            Originator s = (Originator)memento.Deserialize();
            this.state = s.state;
        }
    }
}