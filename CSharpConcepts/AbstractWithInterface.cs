using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    public class AbstractWithInterface
    {
        public void start()
        {
            Employee e1 = new PermanentEmployee();
        }
    }

    public interface IEmployee
    {
        public decimal GetMinimumSalary();
    }

    // We can have an abstract class implement an interface and then declare
    // that method as abstract and let the sub classes implement them..

    public abstract class Employee : IEmployee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Employee() { }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract decimal CalculateBonus(decimal salary);

        public abstract decimal GetMinimumSalary();
    }

    public class PermanentEmployee : Employee
    {
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.1M;
        }

        public override decimal GetMinimumSalary()
        {
            return 15000M;
        }
    }

    public class TemporaryEmployee : Employee
    {
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.5M;
        }

        public override decimal GetMinimumSalary()
        {
            return 15000M;
        }
    }
}
