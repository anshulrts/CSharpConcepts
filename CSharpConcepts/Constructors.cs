using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts.Constructor
{
    public class Constructors
    {
        public void start()
        {
            // Static constructor is called first
            Employee e1 = new Employee();

            Console.WriteLine("----------------------------------");

            // Base class constructor is always called first, even if you define it or not...
            //
            // It is all right if only one of the child class or parent class has default constructor
            // The compiler will create constructor by itself in this case for the other class...
            // 
            // It's an error if there is a Parameterized Constructor defined in the base class but
            // it is not called from the child class with the parameters using base(params)
            //
            // If you do not want to pass the parameters to the base class, then define a default constructor
            // also in the base class.

            Car c1 = new Car();
            Car c2 = new Car("BMW");


        }
    }

    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Default Constructor");
        }

        static Employee()
        {
            Console.WriteLine("Static Default Constructor");
        }
    }

    public class Vehicle
    {
        public int Id { get; set; }
        public Vehicle(int id)
        {
            Console.WriteLine("Vehicle's Parameter constructor");
            Id = id;
        }
        public Vehicle()
        {
            Console.WriteLine("Vehicle's Default");
        }
    }

    public class Car : Vehicle
    {
        public string Name { get; set; }

        public Car()
        {
            Console.WriteLine("Car's Default");
        }

        public Car(string name)
        {
            Name = name;
            Console.WriteLine("Car's Parametrized");
        }
    }

}
