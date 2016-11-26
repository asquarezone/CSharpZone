using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using namespace_name1.namespace_name2;
using testing;

namespace Polymarphism
{

    class test : object
    {
        public int ID;
        public string Name;
        
        public test(int ID,string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }

        public override string ToString()
        {
            return "ID is: " + this.ID.ToString() +" Name is :" + this.Name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           test t = new test(10,"xyz");
           Console.WriteLine(t.ToString());

            Console.Read();

            //try
            //{
            //    File.Open("C:\\junk.txt",FileMode.Open);
            //    throw (new myownexception("Exception"));
            //}
            //catch(myownexception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //CMyMath cpm = new CMyMath();

            //cpm.add(10, 20);
            //cpm.add("hai", 30);
           // cpm.



            //CMyMath m = new CMyMath();
            //m.add(10, 20);
            //Console.WriteLine(m.sub(10, 20));

           // m.add(10.0, 20);

            Console.ReadLine();
        }
    }

    //class MyMath
    //{
    //    //public int add(int i,int j)
    //    //{
    //    //    return i + j;
    //    //}

    //    //public double add(double a,double b)
    //    //{
    //    //    return a + b;
    //    //}

    //    public int add(int a,int b,int c)
    //    {
    //        return a + b + c;
    //    }

    //    //public int add(string i,int j)
    //    //{
    //    //    return  j;
    //    //}

    //}

}
