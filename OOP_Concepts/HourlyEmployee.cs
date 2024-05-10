using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concepts
{
    internal class HourlyEmployee : Employee
    {
        public double HourlyRate { get; private set; }
        public int HoursWorked { get; private set; }

        public HourlyEmployee(string name, double hourlyRate, int hoursWorked)
        {
            Name = name;
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }

        public override void GiveRaise(double amount)
        {
            HourlyRate += amount;
        }

        public override string ToString()
        {
            return $"Hourly Employee: {Name}";
        }
    }

}
