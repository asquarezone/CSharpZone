using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractVsInterface
{
    interface Imath
    {
        int add();
        int sub();
        int mul();
        int div();
    }

    interface Iloger
    {
        int log();
        int add();
    }


    class MyMath2 : Imath,Iloger
    {
        int a;
        int b;
       
        public int div()
        {
            return a / b;
        }

        public int log()
        {
            return a;
        }

        public int mul()
        {
            return a * b;
        }

        public int sub()
        {
            return a - b;
        }

        public int add()
        {
            Console.WriteLine("Inside imath");
            return a + b;
        }       
    }

}
