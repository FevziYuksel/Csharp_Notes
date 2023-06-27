using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cs_Notes 
{
    //C++ friend function equivalent but cannot access private fields

    //class in c# -> sealed partial internal
    internal static class ExtendString
    {
        static readonly Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        public static bool IsValidEmailAddress(this string s) => regex.IsMatch(s);

        public static string Transform(this string s)
        {
            return char.ToUpper(s[0]) + s[1..]; //s[start..end] == s.Substring(1)
        }

    }
}
