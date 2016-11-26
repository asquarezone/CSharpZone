using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIo
{
    class Program
    {
        static void Main(string[] args)
        {

            if(File.Exists(@"C:\Users\DELL\Desktop\Data1.txt"))
            {
                Console.WriteLine("File exist");
                //Console.WriteLine(File.GetLastAccessTime(@"C:\Users\DELL\Desktop\Data1.txt"));
                //File.AppendAllText(@"C:\Users\DELL\Desktop\Data.txt","Added from.net application-1");
                //File.Delete(@"C:\Users\DELL\Desktop\Data.txt");

                File.Move(@"C:\Users\DELL\Desktop\Data1.txt", @"D:\Data1.txt");
            }
            else
            {
                Console.WriteLine("File not available , Creating now");

                File.Create(@"C:\Users\DELL\Desktop\Data1.txt");
            }

            Console.ReadLine();
        }
    }
}
