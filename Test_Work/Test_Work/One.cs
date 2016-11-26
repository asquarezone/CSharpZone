using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Work
{
    public class One
    {
        protected int a;
        internal int b;
        internal protected int c;

        public virtual void test()
        {
            Console.WriteLine("Inside One");
        }
    }

    public class three : One
    {
        public three()
        {
            this.a = 10;
            this.b = 10;
        }

        public override void test()
        {
            base.test();
            Console.WriteLine("Inside Two");
        }
    }

 
}
