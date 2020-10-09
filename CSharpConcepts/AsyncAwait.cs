using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class AsyncAwait
    {
        public async void start()
        {
            int result = await CallAsync();
            Console.WriteLine("Inside Start Method, {0}", result);
        }

        public async Task<int> CallAsync()
        {
            //Task t = new Task(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Thread.Sleep(2000);
            //        Console.WriteLine("Inside Task For Loop {0}", i);
            //    }
            //});

            //Console.WriteLine("Outside For Loop");

            //t.Start();

            //method1();

            //t.Wait();


            // .Wait() is a synchronous wait whereas await is asynchronous
            // Uncomment the above the code to understand the difference
            var res = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("Inside Task For Loop {0}", i);
                }
            });

            Console.WriteLine("Outside For Loop");

            method1();

            await res; // or res.Wait();
            return 1;
        }

        public void method1()
        {
            Console.WriteLine("Hello World from method1");
        }
    }
}
