using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//backspace right to left
//delete left to right
//shift delete whole line
namespace Cs_Notes
{
    internal class TupleTest
    {
        static void Test()
        {
            //formal syntax 
            var t = new Tuple<int, float, string, object?> (1, .1f, "", null);

            //syntax sugar support nullability
            (int, float, int?, long) t2 = (1, 1f, null, 1L);
            t2.Item2 = 2;
            var _ = t2.Item3?.ToString();

            //alternative for custom named split
            (double Sum, int Count) t4 = (4.5, 3);
            var b = t4.Sum;
            var c = t4.Count;

            //better syntax but doesn't support nullability
            var t3 = (1, 1f, 1L);
            t3.Item1 = 1; // omit assignment


        }
    }
}
