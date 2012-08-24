namespace DesignPatterns.Memento
{
    internal class Main
    {
        public static void Test()
        {
            var s = new Originator
            {
                State = "state 1"
            };

            var m = new Caretaker();
            m.Memento = s.SaveMemento();

            s.State = "state 2";

            s.RestoreMemento(m.Memento);
        }
    }
}