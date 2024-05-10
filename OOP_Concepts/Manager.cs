using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concepts
{
    internal class Manager : Employee
    {
        public double MonthlySalary { get; private set; }
        public string Department { get; private set; }

        public Manager(string name, double monthlySalary, string department)
        {
            Name = name;
            MonthlySalary = monthlySalary;
            Department = department;
        }

        public override double CalculateSalary()
        {
            return MonthlySalary;
        }

        public override void GiveRaise(double amount)
        {
            MonthlySalary += amount;
        }

        public override string ToString()
        {
            return $"Manager: {Name} (Department: {Department})";
        }
    }

}
