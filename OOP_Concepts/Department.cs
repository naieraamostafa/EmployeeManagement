using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concepts
{
    internal class Department
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }

        public Department(string name)
        {
            Name = name;
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }

        public void DisplayEmployees()
        {
            Console.WriteLine($"Employees in {Name}:");
            foreach (var employee in Employees)
            {
                Console.WriteLine($"- {employee}");
            }
            Console.WriteLine();
        }

        public double CalculateTotalSalaries()
        {
            return Employees.Sum(e => e.CalculateSalary());
        }

        public List<Employee> SearchEmployee(string name)
        {
            return Employees.Where(e => e.Name.ToLower().Contains(name.ToLower())).ToList();
        }

        public void GiveRaiseToAll(double amount)
        {
            foreach (var employee in Employees)
            {
                employee.GiveRaise(amount);
            }
        }
    }
}
