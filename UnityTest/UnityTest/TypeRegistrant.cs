using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;
using Unity;
using Unity.Lifetime;

namespace UnityTest
{
    public class TypeRegistrant
    {
        IUnityContainer _container;
        public TypeRegistrant(IUnityContainer container)
        {
            _container = container;
        }

        public void RegisterTypes()
        {
            _container.RegisterType<TestClass>(new ContainerControlledLifetimeManager());
            _container.RegisterType<TestClass2>(new ContainerControlledLifetimeManager());
        }
    }
}
