using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            string MobileNumber = null;
            int? i = 25;
            float? f = null;

            DateTime? D = DateTime.Now;

            Console.WriteLine(D?.Hour);


           // Console.WriteLine(i ?? -1);



            //Arithmatic operators

            //int a = 10;
            //int b = 9;



            //string s = (a % 2 == 0) ? "Even" : "Odd" ;

            //Console.WriteLine(sizeof(Int32));
            
           // int i = (a % 2 == 0) ? 1 : 0 ;

            //if( a%2 == 0)
            //{
            //    s = "Even";
            //}
            //else
            //{
            //    s = "Odd";
            //}

           // Console.WriteLine(s);


          //  bool temp = a != c ;

           //Console.WriteLine(temp);

           // if(a != c)
           // {
           //     Console.WriteLine("a == b");
           // }
           // else
           // {
           //     Console.WriteLine("a < b");
           // }



           // int c = (a - b) * b;
           
            //--c;

            //bool b1 = true;

            //if(b1)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}


            //Console.WriteLine(c);

            //Console.WriteLine("a + b =" + (a + b));
            //Console.WriteLine("a - b =" + (a - b));
            //Console.WriteLine("a * b =" + (a * b));
            //Console.WriteLine("a / b =" + (a / b));
            //Console.WriteLine("a % b =" + (a % b));

            Console.ReadLine();

        }
    }
}
