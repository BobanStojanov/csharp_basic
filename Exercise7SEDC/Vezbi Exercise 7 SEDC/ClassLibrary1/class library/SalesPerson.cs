using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.class_library
{
    class SalesPerson : Employee
    {

        private double SuccessSaleRevenue { get; set; }

        public SalesPerson(string FirstName, string LastName, double Salary, Role Role, double SuccessSaleRevenue) : base(FirstName, LastName)
        {
            
            Salary = 500;
            Role = Role.Sales;
            
        }

        public void AddSuccessRevenue(double revenue)
        {
            SuccessSaleRevenue = revenue;
        }

        public override double GetSalary()
        {
            return base.GetSalary() + CalculateBonus();
        }
        private double CalculateBonus()
        {
            if(SuccessSaleRevenue < 2000)
            {
                return 500;
            } else if( SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                return 1000;
            } else
            {
                return 1500;
            }

            
        }

    }
}
