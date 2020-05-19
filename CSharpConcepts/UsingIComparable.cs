using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    public class UsingIComparable
    {
        public void start()
        {
            List<Employee> lstEmployee = new List<Employee>();

            lstEmployee.Add(new Employee(1, "Anshul"));
            lstEmployee.Add(new Employee(2, "AAAAA"));


            // The only reason we are able to call Sort() on a List
            // of object is because this object (i.e Employee) has
            // implemented IComparable interface
            // Otherwise we will get InvalidOperationException.
            lstEmployee.Sort();
        }

        public class Employee : IComparable<Employee>
        {
            public Employee(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public int CompareTo(Employee emp)
            {
                if (emp == null)
                {
                    throw new ArgumentException();
                }

                return Name.CompareTo(emp.Name);
            }

            public int Id { get; set; }

            public string Name { get; set; }


        }
    }
}
