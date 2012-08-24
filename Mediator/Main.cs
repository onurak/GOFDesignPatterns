namespace DesignPatterns.Mediator
{
    internal class Main
    {
        public static void Test()
        {
            // Create chatroom participants
            AbstractColleague colleague1 = new ConcreteColleague() { ID = "1" };
            AbstractColleague colleague2 = new ConcreteColleague() { ID = "2" };
            AbstractColleague colleague3 = new ConcreteColleague() { ID = "3" };
            AbstractColleague colleague4 = new ConcreteColleague() { ID = "4" };
            AbstractColleague colleague5 = new ConcreteColleague() { ID = "5" };

            var mediator = new ConcreteMediator();
            mediator.Register(colleague1);
            mediator.Register(colleague2);
            mediator.Register(colleague3);
            mediator.Register(colleague4);
            mediator.Register(colleague5);

            colleague1.Send("2", "from 1 to 2");
            colleague3.Send("4", "from 3 to 4");
            colleague5.Send("1", "from 5 to 1");
        }
    }
}