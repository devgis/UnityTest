using System;
using System.Collections.Generic;
using System.Text;
using TestLib;
using Unity;

namespace UnityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            TypeRegistrant registrant = new TypeRegistrant(container);
            registrant.RegisterTypes();
            container.Resolve<TestClass2>().Show();
            container.Resolve<TestClass>().Show();
            Console.Read();
        }
    }
}
