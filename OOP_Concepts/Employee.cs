using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concepts
{
    internal abstract class Employee : IEmployee
    {
        public string Name { get; protected set; }

        public abstract double CalculateSalary();

        public abstract void GiveRaise(double amount);
    }

}
