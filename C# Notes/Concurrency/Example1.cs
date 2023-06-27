using Cs_Notes.Dersler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Notes.Concurrency
{
    internal class Example1
    {
        static async Task Method()
        {
            Func<Task> fu = async () => await Console.Out.WriteLineAsync("0:Thread Print");
            var a = fu();
            Task<int> t = Task.Run(() =>
            {
                Task.Delay(100).Wait();
                Console.WriteLine("1:Thread Print");
                return 1;
            });
            Task<int> t2 = Task.Run(() =>
            {
                Console.WriteLine("2:Thread Print");
                return 2;
            });
            Task<int> t3 = Task.Run(() =>
            {
                Console.WriteLine("3:Thread Print");
                return 3;
            });
            Task<int> t4 = Task.Run(() =>
            {
                Console.WriteLine("4:Thread Print");
                return 4;
            });

            //await Console.Out.WriteLineAsync("X");
            //Console.Out.WriteLine("Z");

            Console.Out.WriteLine(await t3);
            Console.Out.WriteLine(await t2);
            Console.Out.WriteLine(await t4);
            Console.Out.WriteLine(await t);
            await a;
        }

        public static async Task MyMethodAsync()
        {
            Task<int> longRunningTask = LongRunningOperationAsync();
            // independent work which doesn't need the result of LongRunningOperationAsync can be done here
            await Console.Out.WriteLineAsync("fevzi");

            //and now we call await on the task 
            int result = await longRunningTask;
            //use the result 
            Console.WriteLine(result);
        }

        public static async Task<int> LongRunningOperationAsync() // assume we return an int from this long running operation 
        {
            await Task.Delay(1000); // 1 second delay
            Console.WriteLine("fevzi2");
            return 1;
        }

        static async Task Main2(string[] args)
        {
            Task task = Print("fevzi");
            Ders1.Func(5, 5.1);

            string a = "fevzi";
            string b = "fevzi";
            Console.WriteLine(a == b);
            await task;
        }

        static Task Print(string arg)
        {
            Console.WriteLine(arg);
            return Task.FromResult("yüksel");
        }
    }
}
