using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"D:\test.txt", FileMode.Open, FileAccess.ReadWrite);
            string s;
            StreamReader sr = new StreamReader(fs);
            while (true)
            {
                s = sr.ReadLine();
                if (s == null)
                    break;
                Console.WriteLine(s);
            }
            sr.Close();

            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Added line 1");
            sw.WriteLine("Added line 2");
            sw.Close();

            //DirectoryInfo d = new DirectoryInfo(@"C:\test");

            //if(d.Exists)
            //{
            //    Console.WriteLine(d.LastAccessTime);
            //}

            //if (Directory.Exists(@"C:\Users\DELL\Desktop\test"))
            //{
            //    Console.WriteLine("Exists");
            // // Directory.CreateDirectory(@"C:\test");
            //    Directory.Move(@"C:\Users\DELL\Desktop\test", @"C:\test");



            //    //string[] files= Directory.GetDirectories(@"C:\Users\DELL\Desktop\test");

            //    //for(int i=0;i < files.Length;i++)
            //    //{
            //    //    Console.WriteLine(files[i]);
            //    //}

            //}
            //else
            //{
            //    Console.WriteLine("not Exists");
            //    Directory.CreateDirectory(@"C:\Users\DELL\Desktop\test");
            //}
            Console.ReadLine();
        }
    }
}
