using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class BusinessEmployee : Employee
    {
        public double bonusBudget = 1000;

        public BusinessEmployee(string name) : base(name, 50000)
        {

        }

        public BusinessEmployee(string name, double baseSalary) : base(name, baseSalary)
        {

        }

        public override string EmployeeStatus() => $"{this.ToString()} with a budget of {bonusBudget}.";
    }
}
