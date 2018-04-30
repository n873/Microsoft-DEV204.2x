using Model;
using System;
using Xunit;

namespace Test
{
    public class Test
    {
        [Fact]
        public void TechnicalEmployee() {
            var employee = new TechnicalEmployee("Zaynah");

            Assert.Equal("2 Zaynah has 5 successful check ins.", employee.EmployeeStatus());
        }

        [Fact]
        public void BusinessEmployee() {
            var employee = new BusinessEmployee("Winter");

            Assert.Equal("3 Winter with a budget of 1000.", employee.EmployeeStatus());
        }
    }
}
