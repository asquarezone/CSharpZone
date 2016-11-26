using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymarphism
{
    abstract class PMyMath
    {
        public virtual void add(int i,int j)
        {
            Console.WriteLine("I am parent add");
        }

        public virtual int sub(int i, int j)
        {
            return i-j;
        }

        public int mul(int i, int j)
        {
            return i * j;
        }

        public int div(int i, int j)
        {
            return i / j;
        }
    }


    class CMyMath : PMyMath
    {
        public override void add(int i, int j)
        {
            Console.WriteLine("I am chile add");
        }

        public void add(string a,int b)
        {

        }

        public int log(int i)
        {
            return i;
        }

    }

    class myownexception:Exception
    {
        public myownexception(string msg):base(msg)
        {

        }
    }
}


namespace namespace_name1
{
    // code declarations
    namespace namespace_name2
    {
        public class test
        {

        }
    }
}


namespace testing
{
    public class test
    {

    }
}
