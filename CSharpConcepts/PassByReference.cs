using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    public class PassByReference
    {
        public void start()
        {
            Product p1 = new Product();
            Product p2 = new Product();

            p1.Name = "Outer1";
            p2.Name = "Outer2";

            // In C#, even here we are passing by value. The value of p1, p2 are being passed.
            // It's just that they are storing the references that's why changes are getting reflected.
            // If you have to pass by reference, you need to use ref keyword explicitly
            modify(p1, p2);

            Console.WriteLine(p1.Name); //Outer 1
            Console.WriteLine(p2.Name); //Inner 2
        }

        void modify(Product p1, Product p2)
        {
            p1 = new Product();
            p1.Name = "Inner1";

            p2.Name = "Inner2";
        }
    }

    public class Product
    {
        public string Name { get; set; }
    }
}
