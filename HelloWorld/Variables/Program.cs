using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variables
{
    class Program
    {
        readonly static double pi;

        static Program()
        {
            pi = 3.14;
        }

        static void Main(string[] args)
        {

            int radius = 10;
            
            Console.WriteLine(pi * radius * radius);

            int i = 1000;
            string s = "10.75";
            double d = 10.675;

            unsafe
            {
                int* p = &i;

                Console.WriteLine(*p);
            }

            DateTime today = DateTime.UtcNow;
            var temp3 = 10;

            object temp4 = 10;

            int abc = temp3;
            int abc1 = (int) temp4;

           // temp3

            Console.WriteLine(today.AddMinutes(-300));

            // double temp = i;

            //int temp = Convert.ToInt32(s);
            string temp = i.ToString();
            string temp2 = d.ToString();

           // Console.WriteLine(sizeof(int));
            Console.WriteLine(temp);


            Console.ReadLine();
        }
    }
}
