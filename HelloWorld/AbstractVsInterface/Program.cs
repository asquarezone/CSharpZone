using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractVsInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath m = new MyMath();
            m.a = 10;
            m.b = 20;

            Math m2 = new MyMath();


            MyMath2 m3 = new MyMath2();

            MyMath2 x = new MyMath2();
            


            Console.WriteLine(m.add());

           // Math m = new Math();

            Console.ReadLine();
        }
    }
}
