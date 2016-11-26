using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Work
{
    class Program
    {

        three th = new three();
       
        
        readonly int i;
        const int j=0;

        public Program()
        {
            i = 25;
        }

        enum colors
        {
            red =1,
            green,
            blue
        }

        static void Main(string[] args)
        {
            three tttt = new three();
            tttt.test();
            int[] array1 = new int[] { 2, 5, 1, 10, 22, 33, 11 };
            Console.WriteLine(string.Join(";", array1));
            Console.WriteLine( array1.Min());
            String s = "Hai";
          
            Console.WriteLine(s.Trim(new char[] { ' ', 'i' }));

            int hai = 10;
            do
            {
                Console.WriteLine(hai);
                hai--;
            } while (hai > 0);


            colors k2;

            DateTime? d1 = null;
            int? days = d1?.Second;

            Console.WriteLine("kjklkflsk" + days);

            k2 = colors.green;
            Console.WriteLine((int)k2);

            switch (k2)
            {
                case colors.red : Console.WriteLine("You entered red");
                                    break;
                case colors.green:
                                Console.WriteLine("You entered red");
                                break;
            }


            double dd = 10.25;
            int inn = (int)dd;
            int[] array = { 10, 20, 30, 40 };
            int kkk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(kkk);
            int[,] array2 = new int[2, 3];
            int? test = 10;
            int test2 = test ?? -1;

            Console.WriteLine(test2);

            //if(array2[2,0] > 0)
            //{

            //}

            foreach(int temp in array)
            {
                Console.WriteLine(temp);
            }

            for(int kk=0;kk < array.Length;kk++)
            {
                Console.WriteLine(array[kk]);
            }


          //  string s = "Ram";

            Console.WriteLine(string.Format("Hai {0}", s));
         //   DateTime D=DateTime.Today()
            

            object o ;

            o = 25;

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
