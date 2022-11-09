using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    public class AbstractClass
    {
        public void start()
        {

        }

        public abstract class Animal
        {
            public string Name { get; set; }

            public abstract void display();
        }

        public abstract class Cow : Animal
        {
            // If we don't implement display() in this, we'll get compile time error
            // Either implement display() here or mark this class as abstract as well
        }

        public class test1: Cow
        {
            // We need to override the display method
            public override void display()
            {

            }
        }
    }
}
