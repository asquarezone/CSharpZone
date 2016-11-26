using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLibrary1
{
    public class ctest1
    {
        public int i;
        internal protected int j;

        internal int add()
        {
            return i + j;
        }
    }

    public class ctest2 : ctest1
    {
        public int sub()
        {
            return (i - j);
        }
    }


    public class ctest3
    {
        public void div()
        {
            ctest1 t1 = new ctest1();
        }
    }
}
