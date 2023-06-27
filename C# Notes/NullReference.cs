using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Notes
{
    internal class NullRef
    {

        /*  Console.WriteLine("{0}, {1}", x, y) == Console.WriteLine($"{x}, {y}")
            'nullptr' in c# is called 'Null Referance exception'
            object obj = null -> throws error object is not nullable
            object? nullObj = null ? nullable version of the type
            'nullObj?.Work()' syntax sugar of 'if(nullObj != null) nullObj.Work();'
            'newObj = nullObj ?? new object();' syntax sugar of 'newObj = nullObj != null ? nullObj : new object();'
        */

        public static int func(int v)
        {
            Byte a = (Byte)v;
            decimal b = Decimal.MaxValue;
            decimal c = 1_000_000M;

            string s = """
                <p> fevzi <p>
                """;
            const string IE_DRIVER_PATH = @"C:\software\selenium\temp\drivers\64";

            const string MY = @"fevzi {a}""adw"" ";
            Console.WriteLine($"{IE_DRIVER_PATH} {s} {c} {b} {a}");
            return v;
        }

        public static double NullReferanceTest(double v)
        {
            char c = (char)65;
            Console.WriteLine(c);

            string? inp = Console.ReadLine();

            //coalesce operator syntax sugar java style ternary
            int.Parse((inp != null) ? inp : "0");
            int.Parse(inp ?? "0");
            inp ??= "0";

            //nullptr guard operator syntax sugar if inp null return null
            if (inp != null) { inp.ToArray(); }
            inp?.ToArray();


            //string? str = "fevzi";
            str = null;
            Console.WriteLine(str?.Replace('e', 'a') == null);
            return v;
        }
    }
}
