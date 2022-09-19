using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    public class ReferenceComparisonByDifferentInsert
    {
        public void start()
        {
            Vehicle v1 = new Vehicle(1, true);
            Vehicle v2 = new Vehicle(2, true);
            Vehicle v3 = new Vehicle(3, true);
            Vehicle v4 = new Vehicle(4, true);

            List<Vehicle> lst1 = new List<Vehicle>();
            List<Vehicle> lst2 = new List<Vehicle>();

            lst1.Add(v1);
            lst2.Add(v1);

            lst1.Add(v2);
            lst2.Add(v2);

            lst1.Add(v3);
            lst2.Add(v3);

            lst1.Add(v4);
            lst2.Add(v4);

            lst1[0].Selected = false;
            Console.WriteLine(lst1[0].Selected);
            Console.WriteLine(lst2[0].Selected); //Both will change
        }

        public class Vehicle
        {
            public int Id { get; set; }
            public bool Selected { get; set; }

            public Vehicle(int id, bool selected)
            {
                Id = id;
                Selected = selected;
            }
        }
    }
}
