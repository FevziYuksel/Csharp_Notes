using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Notes 

{
    internal class DelegateAndEvents
    {
        public static int RetInt()
        { return 0; }

        public static bool IsNull(string? a )
        { return a == null; }


        static void Test()
        {

            Func<int> pt = RetInt;

            Func<string?, bool> isNull = IsNull; 
        }



        public delegate int OpenInstanceDelegate(DelegateAndEvents instance, int x);


        public int RetInt(int x)
        { return x; }

        static void TestOpenInstanceDelegate()
        {
            Type clazz = typeof(DelegateAndEvents);
            MethodInfo? method = clazz.GetMethod("RetInt");
            Delegate d = Delegate.CreateDelegate(typeof(DelegateAndEvents), new DelegateAndEvents(), method);
            OpenInstanceDelegate ptr = (OpenInstanceDelegate)d;
        }
    }

    class Delegate2
    {
        delegate void Foo();
        static void One()
        {
            Console.WriteLine("In one..");
        }

        static void Two()
        {
            Console.WriteLine("In two..");
        }

        public static void TestFuncPtrArray()
        {
            Foo myDelegate = One;
            myDelegate += Two;

            myDelegate(); // Will call One then Two

           
        }

    }

    class Delegate3
    {

        public static void Test1()
        {
            Action greet = delegate { Console.WriteLine("Hello!"); };
            greet();

            Action<int, double> introduce = delegate { Console.WriteLine("This is world!"); }; // Omit <> params

            Func<int, double> introduceFunc = (_) => .5; // _ Omit function params
            introduce(42, 2.7);

        }

        static void FreeFunc()
        {
            Console.Write("1");
        }

        public static void Test2()
        {
            Action mainFunc = FreeFunc;
         
            Action func1 = () => Console.Write("2");

            Action func2 = delegate { Console.Write("3"); };

           
            mainFunc = mainFunc + func1 + func2;

            //Func<int, int> square = x => x * x;
            //mainFunc += square;

            mainFunc();

            
        }

    }



}
