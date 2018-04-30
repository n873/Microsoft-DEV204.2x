using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    
    public class TechnicalEmployee : Employee
    {
        public int successfulCheckIns = 5;
        public TechnicalEmployee(string name) : base(name, 75000)
        {

        }

        public TechnicalEmployee(string name, double baseSalary) : base(name, baseSalary)
        {

        }

        public override string EmployeeStatus() => $"{this.ToString()} has {successfulCheckIns} successful check ins.";
    }
}
