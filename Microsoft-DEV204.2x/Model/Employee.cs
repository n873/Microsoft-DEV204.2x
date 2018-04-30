using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public abstract class Employee
    {
        private static int EmployeeTotal;

        public Employee(string name, double baseSalary)
        {
            EmployeeTotal++;
            Name = name;
            BaseSalary = baseSalary;
            ID = EmployeeTotal;
        }

        public string Name { get; set; }

        public double BaseSalary { get; set; }

        public int ID { get; set; }


        public string GetName() => Name;

        public override string ToString() => $"{ID} {Name}";

        public abstract string EmployeeStatus();
    }
}
