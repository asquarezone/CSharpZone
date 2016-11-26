using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_Work;

namespace Test_Work2
{
    class Two: One
    {
       public Two()
        {
           
        }
    }


    class five
    {
        public five()
        {
            Two tooo = new Two();
            tooo.c = 10;
        }
    }
}
