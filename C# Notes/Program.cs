// See https://aka.ms/new-console-template for more information
using Cs_Notes.Dersler;
using Cs_Notes.Concurrency;

namespace Cs_Notes
{
    class Program
    {


        //static async Task Main(string[] args)
        //{
        //    var task1 = Opera(1, 0);
        //    var task2 =  Opera(2, 500);
        //    Console.Out.WriteLine(task1.IsCompleted);



        //    Console.Out.WriteLine(await task2);
        //    Console.Out.WriteLine(await task1);

        //}

        //static async Task<int> Opera(int val, int delay)
        //{
        //    Task.Delay(delay).Wait();
        //    await Task.Run(() => { Console.WriteLine($"Task1 {val}" ); });
        //    return val;
        //}

        static void Main(string[] args)
        {

        }

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                    // Do something
                    Task.Delay(100).Wait();
                }
            });
        }


        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
                // Do something
                Task.Delay(100).Wait();
            }
        }
    }
}
