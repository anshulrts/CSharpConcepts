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

            // String Interning is concept where every unique string is stored at same location in C#
            // Above, both s1 and s2 are at same location in the heap.
            // Also, string will always always always do value comparison
            Console.WriteLine(s1 == s2); // True -> Value Comparison
            Console.WriteLine(s1.Equals(s2)); // True -> Value Comparison
            Console.WriteLine(object.ReferenceEquals(s1, s2)); // True -> Reference Comparison

            string s3 = "Hello World";
            StringBuilder s4 = new StringBuilder("Hello World");

            //Console.WriteLine(s3 == s4); Type Mismatch, cannot do this...
            Console.WriteLine(s3.Equals(s4)); // False
            Console.WriteLine(object.ReferenceEquals(s3, s4)); // False

            string s5 = "Hello";
            string s6 = "Hello";
            Console.WriteLine(s5.Equals((object)s6)); // True

            string s7 = "Hello";
            string s8 = s7 + " World";
            string s9 = "Hello World";

            Console.WriteLine(s8 == s9); // True
            Console.WriteLine(s8.Equals(s9)); // True
            Console.WriteLine(object.ReferenceEquals(s8, s9)); // False

            string s10 = "Questions";
            string s11 = new string("Questions".ToCharArray());

            Console.WriteLine(s10 == s11); // True -> Value Comparison
            Console.WriteLine(s10.Equals(s11)); // True -> Value Comparison
            Console.WriteLine(object.ReferenceEquals(s10, s11)); // False -> Reference Comparison

            object s12 = "Questions";
            object s13 = new string("Questions".ToCharArray());

            Console.WriteLine(s12 == s13); // False -> Reference Comparison
            Console.WriteLine(s12.Equals(s13)); // True -> Value Comparison
            Console.WriteLine(object.ReferenceEquals(s12, s13)); // False -> Reference Comparison
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
