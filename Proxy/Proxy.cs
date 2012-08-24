using System;
using DesignPatterns.Proxy.Interfaces;

namespace DesignPatterns.Proxy
{
    internal class Proxy : ISubject
    {
        private RealSubject realSubject;

        // Constructor
        public Proxy()
        {
            var ad = AppDomain.CreateDomain("RealSubjectDomain", null, null);

            var o = ad.CreateInstance(
                this.GetType().Namespace,
                this.GetType().Namespace + ".RealSubject");
            realSubject = (RealSubject)o.Unwrap();
        }

        public void Operation()
        {
            realSubject.Operation();
        }
    }
}