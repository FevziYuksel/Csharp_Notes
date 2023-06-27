using Cs_Notes.Dersler;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Notes.Concurrency
{
    internal class Example2
    {
        private static int _c = 0;
        public static async void Test()
        {
            var t1 = Call1();
            var t2 = Call2();
            var t3 = Call3();
            var t4 = Call4();

            //Task.WaitAll(t1, t2, t3, t4);
            var array = await Task.WhenAll(t1, t2, t3, t4);

            Console.WriteLine(array.Length);
            Array.ForEach(array, Console.WriteLine);
        }
        static async Task<int> Call1()
        {
            return await Task.Run(() =>
            {
                //Interlocked.Increment(ref _c);
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Task" + 1);
                }
                Console.WriteLine("---------");
                return 1;

            });
        }

        static async Task<int> Call2()
        {
            return await Task.Run(() =>
            {
                //Interlocked.Increment(ref _c);
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Task" + 2);
                }
                Console.WriteLine("---------");
                return 1;

            });
        }

        static async Task<int> Call3()
        {
            return await Task.Run(() =>
            {
                //Interlocked.Increment(ref _c);
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Task" + 3);
                }
                Console.WriteLine("---------");
                return 1;

            });
        }

        static async Task<int> Call4()
        {
            return await Task.Run(() =>
            {
                //Interlocked.Increment(ref _c);
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Task" + 4);
                }
                Console.WriteLine("---------");
                return 1;

            });
        }
    }
}
