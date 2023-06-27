using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Notes
{
    internal class Class2 : IDisposable
    {
        public static void Guards()
        {
            //C# supports pointer but only in unsafe blocks (methods or free block)
            unsafe
            {
                int i32 = 50;
                int* ptr = &i32;
                int pt = *ptr;

               int[] arr = new int[5];
                
            }

           //calls destructor
            using (var obj = new Class2())
            {
                //Unmanaged resource action with OS
                //File operation, sockets, db calls etc
                //Alternative way to force gc collector to run
            }

            //Lock block same as java synronize 
            //accept any object as mutex
            var obj2 = new Class2();
            lock (obj2)
            {
                //Do concurrent action
            }
        }

        static unsafe void UnsafeFunction() { }

        public void Dispose()
        {
            GC.Collect();
        }

        ~Class2()
        {
            this.Dispose();

            //Destructor syntax sugar
            //try
            //{
            //    this.Equals(new object());
            //}
            //finally
            //{
            //    this.Finalize(); //Deprecated
            //}

        }




    }
}
