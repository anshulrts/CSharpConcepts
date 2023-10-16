using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    public class CustomException
    {
        public void start()
        {
            int x = 10;
            int y = 0;

            try
            {
                int z = x / y;
            }
            catch (MyCustomException)
            {
                Console.WriteLine("Exception");
            }
        }
    }

    public class MyCustomException : Exception
    {
        public MyCustomException()
        {
        }

        public MyCustomException(string message)
            : base(message)
        {
        }

        public MyCustomException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
