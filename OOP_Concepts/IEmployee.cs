using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concepts
{
    internal interface IEmployee
    {
        string Name { get; }
        double CalculateSalary();
        void GiveRaise(double amount);
    }
}
