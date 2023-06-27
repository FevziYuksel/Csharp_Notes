using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Notes
{
    internal class Wrappers
    {
        private string _str = string.Empty;

        public static Wrappers instance = new Wrappers();

        static void LazyClass()
        {
            Lazy<string> lazyStr = new Lazy<string>("Fevzi");

            Console.WriteLine(lazyStr);
        }

        unsafe
        static void StackAlloc(in byte n) 
        {
            if(sizeof(nint) < int.MaxValue) 
            {
                byte* stack = stackalloc byte[(byte)n];
            }
            else 
            {
                Span<byte> stack = stackalloc byte[sizeof(nint)];
            }
        }

        static void Example()
        {
            Console.WriteLine(instance._str  == "");


        }
    }
}
