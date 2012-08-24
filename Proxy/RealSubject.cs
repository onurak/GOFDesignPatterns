using System;
using DesignPatterns.Proxy.Interfaces;

namespace DesignPatterns.Proxy
{
    internal class RealSubject : MarshalByRefObject, ISubject
    {
        public void Operation()
        {
        }
    }
}