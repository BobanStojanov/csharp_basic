using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.class_library

{
    class Employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary;
        public string PrintInfo()
        {
            return $"{FirstName}, {LastName}, {Role}, {Salary}";
        }
        public double GetSalary(double Salary)
        {
            return Salary;
        }
    }
}
