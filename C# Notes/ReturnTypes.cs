using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Notes
{
    internal class ReturnTypes
    {
        static object Func1()
        {
            return 0;
        }

        static bool Func1(out object x)
        {
            x = new object();
            return true;
        }

        static bool Func2(ref object x)
        {
            x = "";
            return true;
        }

        static bool Func3(in object x)
        {
           Console.WriteLine(x);
            return true;
        }

    }
}
