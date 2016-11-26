using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleClass C1 = new ExampleClass();
           
            ExampleStruct S1 = new ExampleStruct();
            
            C1.a = 10;
            C1.b = 20;
            ExampleClass C2 = C1;

            S1.a = 10;
            S1.b = 20;
            ExampleStruct S2 = S1;

            C2.a = 50;
            S2.a = 50;

            Console.WriteLine("C1.a= " + C1.a);
            Console.WriteLine("C2.a= " + C2.a);
            Console.WriteLine("S1.a= " + S1.a);
            Console.WriteLine("S2.a= " + S2.a);

            Console.ReadLine();

        }
    }
}
