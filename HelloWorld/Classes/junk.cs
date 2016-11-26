using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{

    public struct MyMath1
    {
        public MyMath1()
        {

        }
    }

    public abstract class aclass
    {
        public abstract int addd(int a, int b);
    }

    public abstract class bclass
    {
        public abstract int addd(int a, int b);
    }

    class MyChildMath :aclass
    {
        public MyChildMath():base()
        {

        }

        public override int addd(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int log()
        {
            return 10;
        }
    }
    interface iadd
    {

    }

    interface isub
    {

    }
    public class mytest:isub,iadd
    {

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
