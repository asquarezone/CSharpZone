using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{

    struct MyMath1
    {

    }

    public abstract class aclass
    {
        public abstract int addd(int a, int b);
    }

    class MyChildMath:MyMath
    {
        public MyChildMath():base()
        {

        }
        public int log()
        {
            return 10;
        }
    }

    class MyMath
    {
        static public int a;
        static public int b;
        static public int r;


        public static int squareroot(int a)
        {
            return a * a;
        }

        static MyMath()
        {
            Console.WriteLine("I am in Static constructor");
            r = squareroot(10);
        }

        public MyMath(int a, int b)
        {
            // Console.WriteLine("I am in constructor");
            Console.WriteLine("I am in 2 constructor");
            // pi = pii;
           
        }
        public MyMath()
        {
            Console.WriteLine("Parent constructor");
        }

        public MyMath(int a, int b, int r) : this(a, b)
        {
            Console.WriteLine("I am in 3 constructor");
            // this.r = r;
        }

        ~MyMath()
        {
            Console.WriteLine("I am in distructor");
        }

        public double area()
        {
            return pi * r * r;
        }

        public int add()
        {
            return a + b;
        }

        public int sub()
        {
            return a - b;
        }

        public int mul()
        {
            return a * b;
        }

        public int div()
        {
            return a / b;
        }

    }
}
