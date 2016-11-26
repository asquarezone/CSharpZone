using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary1;

namespace AccesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            test2 t2 = new test2();
            t2.i = 20;
            t2.j = 10;
            Console.WriteLine(t2.add());
            Console.WriteLine(t2.sub());

            test1 t1 = new test1();

            t1.i = 20;
            t1.j = 10;

            ctest1 t3 = new ctest1();

            




            Console.ReadLine();
        }
    }


    class test1
    {
        internal int i;
        internal int j;

        internal int add()
        {
            return i + j;
        }
    }

    class test2 : test1
    {
        public int sub()
        {
            return (i - j);
        }
    }

    class test3 : ctest1
    {
       public int div()
        {
            return j;
        }
    }


}
