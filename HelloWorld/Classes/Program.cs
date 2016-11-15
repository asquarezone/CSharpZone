using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class Program
    {
        

        static void Main(string[] args)
        {
            MyMath m = new MyMath();
            MyChildMath m1 = new MyChildMath();

            MyMath m2 = new MyChildMath();
           
            
            //string s = "Hello World..!!";

            //Console.WriteLine(s.IndexOf('o'));

            

            //MyMath math1 = new MyMath();     // math1.a =2 ,math1.b =3
            //MyMath math2 = new MyMath(4, 5);    //  math2.a =4 ,math2.b =5
            //MyMath math3 = new MyMath(30,40);

            //Console c = new Console();
            

           Console.WriteLine(MyMath.squareroot(10));



            Console.ReadLine();
          


            // MyMath math1 = new MyMath();

            //math.a = 10;
            //math.b = 20;
            //math.r = 7;

            //Console.WriteLine(math.area());

            //Console.WriteLine(math.add());
            //Console.WriteLine(math.sub());
            //Console.WriteLine(math.mul());
            //Console.WriteLine(math.div());

         

        }
    }
}
