using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int age = -1;

                if(age < 0)
                {
                   // Exception e1 = new Exception("Hai");
                   AgeNotValidException e = new AgeNotValidException("Age invalid");
                    throw e;
                }
            }
            catch(AgeNotValidException e)
            {

            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("Hello world");
            Console.ReadLine();

        }
    }

    class AgeNotValidException : Exception
    {
      public AgeNotValidException(string message) : base(message)
        {

        }
    }

}
