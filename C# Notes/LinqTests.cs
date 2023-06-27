using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cs_Notes

{
    internal class LinqTests
    {
        public static void StringInterpolation()
        {
            decimal[] amounts = { 16305.32m, 18794.16m };
            Console.WriteLine("   Beginning Balance           Ending Balance");
            Console.WriteLine("   {0,-28:C2}{1,14:C2}", amounts[0], amounts[1]);
            Console.WriteLine($"  {amounts[0],-28:C2}{amounts[1],14:C2}");
            Console.WriteLine(@"  / \n   ");

            Console.WriteLine("""
                {
                "key" : "value"
                }
                """);
        }
        static void Test()
        {
            IList<string> list = new List<string>
            {
                "fevzi",
                "yüksel",
                "aykut",
                "özdemir"
            };

            list.Where(x => x.Contains("f")).Select(x => x.Replace('e', 'a')).ToList().ForEach(x => Console.WriteLine(x));

            (list as List<string> ?? list.ToList()).ForEach(x => Console.WriteLine(x));
        }


        static int A(string x) { return int.Parse(x); }

        public static void Test2()
        {
            IList<string> list = new List<string> { "0", "1", "2", "3" };

            //List<int>? nums = list.Select(number => int.Parse(number)).ToList();

            foreach (var item in list.Select(int.Parse).ToList())
            {
                Console.WriteLine(item);
            }


            list.Select(new Func<string, int>(A)).ToList();

            list.Select(A).ToList();

            /*
            try
            {
                nums = list.Select(number => int.Parse(number)).ToList();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.StackTrace);
                foreach (var item in nums)
                {
                    Console.WriteLine(item);
                }
            }
            */


        }


    }
}
