using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concepts
{
    internal class ContractEmployee : Employee
    {
        public double MonthlyContractAmount { get; private set; }

        public ContractEmployee(string name, double monthlyContractAmount)
        {
            Name = name;
            MonthlyContractAmount = monthlyContractAmount;
        }

        public override double CalculateSalary()
        {
            return MonthlyContractAmount;
        }

        public override void GiveRaise(double amount)
        {
            MonthlyContractAmount += amount;
        }

        public override string ToString()
        {
            return $"Contract Employee: {Name}";
        }
    }

}
