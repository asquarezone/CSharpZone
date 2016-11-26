using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structure
{
    public class ExampleClass
    {
        public int a;
        public int b;

        public ExampleClass()
        {
            //
            //
        }

    }

    struct ExampleStruct
    {
        public int a;
        public int b;

        public ExampleStruct(int a)
        {
            this.a = a;
            this.b = 10;
        }

        public int add()
        {
            return a + b;
        }

        
    }

}
