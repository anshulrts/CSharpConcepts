using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    class ConstructorChaining
    {
        public void start()
        {
            Foo a = new Foo(), b = new Foo(456, "def"), c = new Foo(123), d = new Foo("abc");
        }

        class Foo
        {
            private int id;
            private string name;

            public Foo() : this(0, "")
            {
                Console.WriteLine("Inside Foo()");
            }

            public Foo(int id, string name)
            {
                this.id = id;
                this.name = name;
                Console.WriteLine("Inside Foo(int id, string name)");
            }

            public Foo(int id) : this(id, "")
            {
                Console.WriteLine("Inside Foo(id, \"\")");
            }

            public Foo(string name) : this(0, name)
            {
                Console.WriteLine("Inside Foo(string name)");
            }
        }
    }
}
