using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{

    sealed class MyMath 
    {
        public MyMath() 
        {

        }

        public int square()
        {
            return 10 * 10;
        }
    }

    class x
    {

    }


    class AddSub : MyMath
    {
        public int a;
        public int b;

        public AddSub(int a, int b)
        {
            Console.WriteLine("I am in Parent");
            this.a = a;
            this.b = b;
        }

        public int add()
        {
            return a + b;
        }

        public int sub()
        {
            return a - b;
        }
    }


    class MulDiv : MyMath
    {
        public int c;
        public int d;

        public MulDiv(int c, int d) 
        {
            Console.WriteLine("I am in Child");
            this.c = c;
            this.d = d;
        }

        public int mul()
        {
            return c * d;
        }

        public int div()
        {
            return c /d;
        }
    }


 

}
