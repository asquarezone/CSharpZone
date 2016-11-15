using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{

    enum week
    {
        sunday,
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        staurday
    }

    class Program
    {

        static void Main(string[] args)
        {

            week i = week.wednesday;

            Console.WriteLine((int)i);

            switch (i)
            {
                case week.sunday:
                    Console.WriteLine("Sunday");
                    break;

                case week.monday:
                    Console.WriteLine("Monday");
                    break;

                case week.tuesday:
                    Console.WriteLine("Tuesday");
                    break;

                case week.wednesday:
                    Console.WriteLine("WednesDay");
                    break;

                case week.thursday:
                    Console.WriteLine("ThursDay");
                    break;

                case week.friday:
                    Console.WriteLine("Friday");
                    break;

                case week.staurday:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }


            Console.ReadLine();

            //string stemp = "10,20,30,40,50";
            //string[] array = stemp.Split(',');
            //foreach(string s in array)
            //{
            //    Console.WriteLine(s);
            //}

            //string s2 = "hellow world..!!";
            //Console.WriteLine(s2.ToUpper());


            //string s2 = string.Join(";", array);
            //Console.WriteLine(s2);

            //string s1 = "Hello World";

            //s1 = s1.Substring(1, 4);

            //Console.WriteLine(s1);

            //int[] array = new int[] { 10, 20, 30, 40, 50 };


            //for(int i=0;i<7;i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //foreach (int temp in array)
            //{
            //    Console.WriteLine(temp);
            //}

            //int[,] array = new int[3,2] { {10,20 }, { 30, 40 }, { 50, 60 } } ;

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine(array[i, j]);
            //    }
            //}



            Console.ReadLine();


        }
    }
}
