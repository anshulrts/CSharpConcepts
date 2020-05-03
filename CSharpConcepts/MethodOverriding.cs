using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    public class MethodOverriding
    {
        public void start()
        {
            Parent p = new Parent();
            Son s = new Son();

            p.Display();
            p.Test();
            p.Show();

            s.Display();
            s.Test();
            s.Show();

            Parent p1 = new Son();
            p1.Display();
            p1.Test();
            p1.Show();
        }

        class Parent
        {
            int x = 10;


            // Display is defined in Parent But Not in Son
            // In all of the three references, this version will be called
            // No virtual keyword is added here
            public void Display()
            {
                Console.WriteLine("Display In Parent. x = {0}", x);
            }

            // Same as above, but virtual Key is added
            // In all of the three references, this version will be called
            public virtual void Test()
            {
                Console.WriteLine("Test In Parent. x = {0}", x);
            }

            // Virtual + Override
            // Respective Reference's version will be called
            public virtual void Show()
            {
                Console.WriteLine("Show In Parent. x = {0}", x);
            }
        }

        class Son : Parent
        {
            int x = 20;

            public override void Show()
            {
                Console.WriteLine("Show In Son. x = {0}", x);
            }
        }
    }
}
