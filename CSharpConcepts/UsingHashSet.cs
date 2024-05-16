using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    public class UsingHashSet
    {
        public void start()
        {
            HashSet<int> hInt = new HashSet<int>();

            hInt.Add(1);
            hInt.Add(2);
            hInt.Add(3);
            hInt.Add(3);

            Console.WriteLine(hInt.Count); //3

            HashSet<Employee> hEmp = new HashSet<Employee>();
            hEmp.Add(new Employee { Name = "A"});
            hEmp.Add(new Employee { Name = "B" });
            hEmp.Add(new Employee { Name = "C" });
            hEmp.Add(new Employee { Name = "C" });

            Console.WriteLine(hEmp.Count); //4
        }

        class Employee
        {
            public string Name { get; set; }
        }
    }
}
