using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class AsyncAwait
    {
        public async Task start()
        {
            //int result = await CallAsync();
            //Console.WriteLine("Inside Start Method, {0}", result);

            Console.WriteLine("Calling private async Task<int> TestAsync()");
            int x = await TestAsync();
            Console.WriteLine("After int x = await TestAsync();");

        }

        private async Task<int> TestAsync()
        {
            Console.WriteLine("Inside TestAsync, waiting for 5 sec now...");
            Console.WriteLine("Outside For Loop");
            // From the notes, you'll understand that Task doesn't create a new thread, instead it takes an existing thread from ThreadPool.
            // If you change the below statement to Thread.Sleep(5000), you'll not get async behaviour as introducing async and await themselves don't create the task.
            // There must be a Task.Delay or Task.Start to make async behaviour happen.
            await Task.Delay(5000);
            Console.WriteLine("Wait for 5 sec ended");
            return 10;
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
