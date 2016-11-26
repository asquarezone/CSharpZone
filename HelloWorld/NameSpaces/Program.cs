using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Men;
using Men.clothing;
using Women;

namespace NameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Men.Watches w = new Men.Watches();

            wallet w1 = new wallet();

            shirt s = new shirt();
        }
    }
}


namespace Men
{
    namespace clothing
    {
        class shirt
        {

        }
    }
    class Watches
    {

    }

    class wallet
    {

    }
}


namespace Women
{
    class Watches
    {

    }
}
