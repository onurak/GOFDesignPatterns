namespace DesignPatterns.Observer
{
    internal class Main
    {
        public static void Test()
        {
            var concreteSubject = new ConcreteSubject("state 1");

            concreteSubject.Attach(new ConcreteObserver("1"));
            concreteSubject.Attach(new ConcreteObserver("2"));

            concreteSubject.State = "state 2";
            concreteSubject.State = "state 3";
        }
    }
}