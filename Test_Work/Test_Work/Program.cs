using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Work
{
    class Program
    {
        readonly int i;
        const int j=0;

        public Program()
        {
            i = 25;
        }

        static void Main(string[] args)
        {
            double dd = 10.25;
            int inn = (int)dd;

            string s = "Ram";

            Console.WriteLine(string.Format("Hai {0}", s));
            DateTime D=DateTime.Today()
            

            object o = 25;

            int k = (int)o;

            var j = 10;

            Console.WriteLine(k);

            unsafe
            {
                int j1 = 10;
                int* i = &j1;
                Console.WriteLine(*i);
                Console.WriteLine((int)i);
                // Console.WriteLine(&i);
            }

            //string s = "Hai";
            string s1 = s;
            Console.WriteLine(s1);
            s = s + "Hello";
            Console.WriteLine(s1);

            Object O = "Hai";
            Object O2 = O;
            Console.WriteLine(O2);
            O = O + "Hello";
            Console.WriteLine(O2);

            int a = 2;
            int b = 3;
            Console.WriteLine(a << 2);

            string ss = null;

            Console.WriteLine(ss ?? "Hai");

            Console.ReadLine();
        }
    }
}
