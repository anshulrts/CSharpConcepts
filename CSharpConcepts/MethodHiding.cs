using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    public class MethodHiding
    {
        public void start()
        {
            Parent p = new Parent();
            Son s = new Son();

            p.display();
            s.display();

            p.Show();
            s.Show();

            Parent p1 = new Son();
            p1.display();
            p1.Show();
        }
    }

    public class Parent
    {
        int x = 10;

        public void display()
        {
            Console.WriteLine("In Parent. x = {0}", x);
        }

        public void Show()
        {
            Console.WriteLine("Show In Parent. x = {0}", x);
        }
    }

    class Son : Parent
    {
        int x = 20;

        // Even though you can declare a method with same name as that in parent
        // It will give a warning only and will call respective method.
        // But still better to use new keyword like in Show()
        public void display()
        {
            Console.WriteLine("In Son. x = {0}", x);
        }

        public new void Show()
        {
            Console.WriteLine("Show In Son. x = {0}", x);
        }
    }
}
