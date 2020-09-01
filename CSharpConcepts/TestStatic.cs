using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    public class TestStatic
    {
        public void start()
        {
            Test t = new Test();
            t.Print(); //Test Value : 10
        }
    }

    public class Test
    {
        public static int TestValue;
        
        public Test()
        {
            if (TestValue == 0)
            {
                TestValue = 5;
            }
        }

        static Test()
        {
            if (TestValue == 0)
            {
                TestValue = 10;
            }
        }

        public void Print()
        {
            if (TestValue == 5)
            {
                TestValue = 6;
            }

            Console.WriteLine("Test Value : {0}", TestValue);
        }
    }

}
