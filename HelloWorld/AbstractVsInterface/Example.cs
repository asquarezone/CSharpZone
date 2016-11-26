using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractVsInterface
{
    abstract class Math
    {
        public int a;
        public int b;

        abstract public int add();
       
        abstract public int sub();

        public int div()
        {
            return a / b;
        }
    }

    class MyMath : Math
    {
        public override int add()
        {
            return a + b;
        }

        public override int sub()
        {
            return a - b;
        }
    }

    abstract class MyAnotherMath : Math
    {
        public override int add()
        {
            return a + b; 
        }

        abstract public int mul();

        //abstract public int sub();
    }

    class final1 : MyAnotherMath
    {
        public override int mul()
        {
            throw new NotImplementedException();
        }

        public override int sub()
        {
            throw new NotImplementedException();
        }
    }

}
