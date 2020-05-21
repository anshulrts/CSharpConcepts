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
            await CallAsync();
            Console.WriteLine("Inside Start Method");
        }

        public async Task CallAsync()
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


            // Instead of above written code with .Start() and .Wait
            // We can use following code with object initializer and await
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
        }

        public void method1()
        {
            Console.WriteLine("Hello World from method1");
        }
    }
}
