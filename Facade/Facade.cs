namespace DesignPatterns.Facade
{
    internal class Facade
    {
        private SubsystemA subSystemA = new SubsystemA();
        private SubsystemB subSystemB = new SubsystemB();
        private SubsystemC subSystemC = new SubsystemC();

        public void Operation()
        {
            subSystemA.Operation();
            subSystemB.Operation();
            subSystemC.Operation();
        }
    }
}