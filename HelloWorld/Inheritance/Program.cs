using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           //AddSub addsub = new AddSub();
            MulDiv muldiv = new MulDiv(10, 20);

            AddSub addsub = new AddSub();

            


            MyMath m = new MyMath();

            
            //muldiv.a = 10;
           // muldiv.b = 20;

           Console.WriteLine(muldiv.add());
            Console.WriteLine(muldiv.sub());

            Console.ReadLine();
        }
    }
}
