using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = 10.00f;
            int sum=0;
            int[] array = new int[] { 10, 23, 6, 8, 9,10,9,8,34,56};

            //for(int i=0; i<8 ;i++)
            //{
            //    sum += array[i];
            //}


            foreach(int temp in array)
            {
                sum += temp;
            }

            Console.WriteLine(sum);

            //int i = 0;
            //int sum = 0;

            //do
            //{
            //    sum += i;

            //    i++;
            //} while (i < 0);

            //Console.WriteLine(sum);

            //int sum = 0;

            //for(int i=0; i<=100;i++)
            //{
            //   if(i == 5)
            //    {
            //        break;
            //    }

            //    sum += i;
            //}

            //Console.WriteLine(sum);
                
            //Console.Write("Enter a Number ::");

            //int sum = add(10, 20);
            //int i =Convert.ToInt32(Console.ReadLine());


            //switch(i)
            //{
            //    case 1: Console.WriteLine("Sunday");
            //             break;

            //    case 2:
            //        Console.WriteLine("Monday");
            //        break;

            //    case 3:
            //        Console.WriteLine("Tuesday");
            //        break;

            //    case 4:
            //        Console.WriteLine("WednesDay");
            //        break;
            //    case 5:
            //        Console.WriteLine("ThursDay");
            //        break;
            //    case 6:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Saturday");
            //        break;

            //    default:
            //        Console.WriteLine("Incorrect input");
            //        break;
            //}


            //if( i%2 == 1)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}

            Console.ReadLine();

        }

        static int add(int a,int b)
        {
            return a + b;
        }

    }
}
