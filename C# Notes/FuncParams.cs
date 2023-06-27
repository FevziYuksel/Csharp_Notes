using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Notes
{
    internal class FuncParams
    {
        //in keyword used for const func parameters
        static void Func(in int a)
        {
            //a = 1;
        }

        static void Func(in string a)
        {
            //const T& equivalent
            //a = "";
        }

        static void Func2(ref int a)
        {
            //T& equivalent
            //a initilize before enter
        }

        static void Func3(out int a)
        {
            //T& but with initilization check
            //a must be initilized
            a = 0;
        }

        static int? Func4(int? a)
        {
            //a is nullable
            a = null;
            return a;
        }

        static int Func5(int a)
        {
            // cannot b null
            //a = null; 
            return a;
        }
    }
}
