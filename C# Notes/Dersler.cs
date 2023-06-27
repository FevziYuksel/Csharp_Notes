using System.Numerics;

namespace Cs_Notes.Dersler
{
    /*
     * C# overload & operator between bools as short-circuitless &&.
     * Divide by zero is exception for Integer types but can be INF, -INF or NaN for Floating types (C/C++ is Undefined behavior).
     * Input doesn't have any formating functionality it always take char/string.
     * Convert class is used for string parsing also all structs have Parse method. 
     * cw is c# cout
     * CTRL + K + D -> fix code style  (java CTRL L) 
     * CTRL + K + C Single line comment
     * CTRL + K + U Single line uncomment
     */
    internal class Ders1
    {
        /**C# types*/
        public static void Types<T>()
        {

            /*Integers */
            {

                byte i8 = 255; Byte _i8 = 0;
                sbyte u8 = -128; SByte _u8 = -1;
                short i16 = 0; Int16 _i16 = 0;
                ushort u16 = 0; UInt16 _u16 = 0;
                int i32 = 0; Int32 _i32 = 0;
                uint u32 = 0; UInt32 _u32 = 0;
                //Native C# integer ??
                nint ni32 = 0;
                nuint nu32 = 0;
                long i64 = 0; Int64 _i64 = 0;
                ulong u64 = 0; UInt64 _u64 = 0;
                //C# doesn't have build in 128 bit integer type
                Int128 i128 = 0;
                UInt128 u128 = 0;
                //Decimal - arbitrarily integer type no rounding error
                BigInteger bigInteger = 0;

            }
            //floating points
            {

                float f32 = .0f; Single _f32 = .1f;
                double f64 = 2.0; Double _f64 = 4.0; /*4.; c# doesn't let c literal */
                //Decimal - 128 floating point type no rounding error
                decimal f128 = 0m; Decimal _f128 = 0M;

            }
            //Character 
            {
                char c = 'a'; Char c2 = 'a';
                string s = "abc"; String s2 = "abc";
            }

            //Logical 
            {
                bool b = true; Boolean b2 = false;
            }


            T[] arr = { };
            T[] arr2 = new T[] { };

        }
        public static bool IsInteger(ValueType value)
        {
            return (value is SByte || value is Int16 || value is Int32
                    || value is Int64 || value is Byte || value is UInt16
                    || value is UInt32 || value is UInt64
                    || value is BigInteger);
        }

        public static bool IsFloat(ValueType value)
        {
            return (value is float | value is double | value is Decimal);
        }

        public static bool IsNumeric(ValueType value)
        {
            return (value is Byte ||
                    value is Int16 ||
                    value is Int32 ||
                    value is Int64 ||
                    value is SByte ||
                    value is UInt16 ||
                    value is UInt32 ||
                    value is UInt64 ||
                    value is BigInteger ||
                    value is Decimal ||
                    value is Double ||
                    value is Single);
        }

        //type order can be used as overload but not the return types
        public static void Func(int n1, double n2)
        {
            //declaring a variable
            int num1;
            //assigning a value a variable
            num1 = 13;
            //declearing and initializing a variable in one go
            int num2 = 23;

            Console.WriteLine($"num1 = {num1}\nnum2 = {num2}");
            Console.Read();
        }

        static void Func(double n1, int n2)
        {
            var variable = "";
            
            Console.WriteLine(nameof(variable));
        }
    }
}
