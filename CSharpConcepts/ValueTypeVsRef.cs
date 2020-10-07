using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    public class ValueTypeVsRef
    {
        public void start()
        {
            Test1 t1 = new Test1("Abc");
            Test1 t2 = new Test1("Def");
            Test1 t3 = new Test1("Ghi");

            methodcall(t1, t2, ref t3);

            Console.WriteLine(t1.Name); //xyz
            Console.WriteLine(t2.Name); //Def - Because setting test2 = null in the method removed the reference of test2 to the
                                        //memory location. It didn't affect the object in the heap.
            //Console.WriteLine(t3.Name);//t3 is null as reference was passed
        }

        private void methodcall(Test1 test1, Test1 test2, ref Test1 test3)
        {
            test1.Name = "xyz";
            test2 = null;
            test3 = null;
        }
    }

    class Test1
    {
        public Test1(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
