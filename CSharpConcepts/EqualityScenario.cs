using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    public class EqualityScenario
    {
        public void start()
        {
            // There are several ways of checking equality in C#
            // We can use :-
            // 1. ==
            // 2. static bool Equals(Object? objA, Object? objB);
            // 3. virtual bool Equals(Object? obj);
            // 4. static bool ReferenceEquals(Object? objA, Object? objB);

            // Value Types
            int a = 10;
            int b = 10; // Same results for int b = a;

            Console.WriteLine(a == b); // True -> Value Comparison
            Console.WriteLine(a.Equals(b)); // True -> Value Comparison
            Console.WriteLine((object)a == (object)b); // False -> Reference Comparison. Boxing occurs, values converted to references
            Console.WriteLine((object)a.Equals((object)b)); // True -> Value Comparison.

            // Reference Types
            Vehicle v1 = new Vehicle(1);
            Vehicle v2 = new Vehicle(1);

            Console.WriteLine(v1 == v2); // False -> Reference comparison. Both pointing to different memory location
            Console.WriteLine(v1.Equals(v2)); // False -> Reference comparison. Unless you override Equals or implement IEquatable<>
            Console.WriteLine(object.Equals(v1, v2)); // False -> Reference comparison.

            Vehicle v3 = new Vehicle(1);
            Vehicle v4 = v3;
            Console.WriteLine(v3 == v4); // True -> Reference comparison. Both pointing to same memory location
            Console.WriteLine(v3.Equals(v4)); // True -> Reference comparison. Unless you override Equals or implement IEquatable<>
            Console.WriteLine(object.Equals(v3, v4)); // True -> Reference comparison.

            // Reference Types - Exception : strings (string comparison is case sensitive)
            string s1 = "Hello";
            string s2 = "Hello";

            Console.WriteLine(s1 == s2); // True -> Value Comparison
            Console.WriteLine(s1.Equals(s2)); // True -> Value Comparison
            Console.WriteLine(object.ReferenceEquals(s1, s2)); // True -> Value Comparison

            string s3 = "Hello World";
            StringBuilder s4 = new StringBuilder("Hello World");

            //Console.WriteLine(s3 == s4); Type Mismatch, cannot do this...
            Console.WriteLine(s3.Equals(s4)); // False
            Console.WriteLine(object.ReferenceEquals(s3, s4)); // False

            string s5 = "Hello";
            string s6 = "Hello";
            Console.WriteLine(s5.Equals((object)s6)); // True

        }

        public class Vehicle
        {
            public Vehicle(int id)
            {
                Id = id;
            }
            public int Id { get; set; }
        }
    }
}
