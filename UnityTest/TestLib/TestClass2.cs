using System;
using System.Collections.Generic;
using System.Text;

namespace TestLib
{
    public class TestClass2
    {
        string id=null;
        public TestClass2()
        {
            id = Guid.NewGuid().ToString();
        }
        public void Show()
        {
            Console.WriteLine($"I'm class2{id}");
        }
    }
}
