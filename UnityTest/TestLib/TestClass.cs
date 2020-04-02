using System;
using System.Collections.Generic;
using System.Text;

namespace TestLib
{
    public class TestClass
    {
        TestClass2 _class2 = null;
        public TestClass(TestClass2 class2)
        {
            _class2 = class2;
        }

        public void Show()
        {
            _class2.Show();
        }
    }
}
