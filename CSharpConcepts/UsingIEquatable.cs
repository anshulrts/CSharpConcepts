using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CSharpConcepts.UsingIEquatableNamespace
{
    public class UsingIEquatable
    {
        public void start()
        {
            Employee e1 = new Employee(1);
            Employee e2 = new Employee(1);
            Employee e3 = new Employee(2);
            Employee e4 = e3;


            Console.WriteLine(e1 == e2); // False -> Reference Test
            Console.WriteLine(e1.Equals(e2)); // False -> Reference Test
            Console.WriteLine(e3 == e4); // True -> Reference Test
            Console.WriteLine(e3.Equals(e4)); // True -> Reference Test

            // In student class, we have defined that equals should do Id comparison
            Student s1 = new Student(1);
            Student s2 = new Student(1);
            Student s3 = new Student(2);
            object s4 = new Student(1);

            Console.WriteLine(s1 == s2); // False -> Reference Comparison
            Console.WriteLine(s1.Equals(s2)); // True -> Id Comparison because of method defined in IEquatable
            Console.WriteLine(s1.Equals(s3)); // False -> Id Comparison because of method defined in IEquatable
            Console.WriteLine(s1.Equals(s4)); // False -> The Equals called here is the one defined in object class
                                              //          When we pass the parameter as student, only then IEquatable's
                                              //          Equals is called.

            // In order to avoid unexpected bugs, we must override the equals and gethashcode in base class
            Vehicle v1 = new Vehicle(1);
            object v2 = new Vehicle(1);

            Console.WriteLine(v1.Equals(v2)); // True
        }
    }

    public class Employee
    {
        public Employee(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }

    public class Student : IEquatable<Student>
    {
        public Student(int id)
        {
            Id = id;
        }
        public int Id { get; set; }

        public bool Equals(Student other)
        {
            return Id == other.Id;
        }
    }

    public class Vehicle : IEquatable<Vehicle>
    {
        public Vehicle(int id)
        {
            Id = Id;
        }
        public int Id { get; set; }
        
        public bool Equals(Vehicle other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            Vehicle v = obj as Vehicle;
            return Id == v.Id;
        }

        // Whenever we override Equals() of Object, we also override GetHashCode for consistency
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
