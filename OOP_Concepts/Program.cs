using OOP_Concepts;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create departments
        Department engineeringDept = new Department("Engineering");
        Department salesDept = new Department("Sales");

        Manager manager = AddManager(engineeringDept, salesDept);

        Console.WriteLine("Manager: " + manager.Name + " (Department: " + manager.Department + ")");

        bool running = true;
        while (running)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add Hourly Employee");
            Console.WriteLine("2. Add Contract Employee");
            Console.WriteLine("3. Calculate Total Salaries");
            Console.WriteLine("4. Give Raise to All");
            Console.WriteLine("5. Search Employee");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddHourlyEmployee(engineeringDept, salesDept);
                    break;
                case "2":
                    AddContractEmployee(engineeringDept, salesDept);
                    break;
                case "3":
                    CalculateTotalSalaries(engineeringDept, salesDept);
                    break;
                case "4":
                    GiveRaiseToAll(engineeringDept, salesDept);
                    break;
                case "5":
                    SearchEmployee(engineeringDept, salesDept);
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }

    static Manager AddManager(Department engineeringDept, Department salesDept)
    {
        Console.Write("Enter Manager Name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Select Department:");
        Console.WriteLine("1. Engineering");
        Console.WriteLine("2. Sales");
        Console.Write("Enter department number: ");
        int departmentChoice = int.Parse(Console.ReadLine());

        switch (departmentChoice)
        {
            case 1:
                Console.Write("Enter Monthly Salary: ");
                double monthlySalary = double.Parse(Console.ReadLine());
                return new Manager(name, monthlySalary, "Engineering");
            case 2:
                Console.Write("Enter Monthly Salary: ");
                double monthlySalary2 = double.Parse(Console.ReadLine());
                return new Manager(name, monthlySalary2, "Sales");
            default:
                Console.WriteLine("Invalid choice! Manager not added.");
                return null;
        }
    }

    static void AddHourlyEmployee(Department engineeringDept, Department salesDept)
    {
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Hourly Rate: ");
        double hourlyRate = double.Parse(Console.ReadLine());

        Console.Write("Enter Hours Worked: ");
        int hoursWorked = int.Parse(Console.ReadLine());

        Console.WriteLine("Select Department:");
        Console.WriteLine("1. Engineering");
        Console.WriteLine("2. Sales");
        Console.Write("Enter department number: ");
        int departmentChoice = int.Parse(Console.ReadLine());

        switch (departmentChoice)
        {
            case 1:
                engineeringDept.AddEmployee(new HourlyEmployee(name, hourlyRate, hoursWorked));
                break;
            case 2:
                salesDept.AddEmployee(new HourlyEmployee(name, hourlyRate, hoursWorked));
                break;
            default:
                Console.WriteLine("Invalid choice! Employee not added.");
                break;
        }
    }

    static void AddContractEmployee(Department engineeringDept, Department salesDept)
    {
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Monthly Contract Amount: ");
        double monthlyContractAmount = double.Parse(Console.ReadLine());

        Console.WriteLine("Select Department:");
        Console.WriteLine("1. Engineering");
        Console.WriteLine("2. Sales");
        Console.Write("Enter department number: ");
        int departmentChoice = int.Parse(Console.ReadLine());

        switch (departmentChoice)
        {
            case 1:
                engineeringDept.AddEmployee(new ContractEmployee(name, monthlyContractAmount));
                break;
            case 2:
                salesDept.AddEmployee(new ContractEmployee(name, monthlyContractAmount));
                break;
            default:
                Console.WriteLine("Invalid choice! Employee not added.");
                break;
        }
    }

    static void RemoveEmployee(Department engineeringDept, Department salesDept)
    {
        Console.WriteLine("Select Department:");
        Console.WriteLine("1. Engineering");
        Console.WriteLine("2. Sales");
        Console.Write("Enter department number: ");
        int departmentChoice = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        switch (departmentChoice)
        {
            case 1:
                var engineeringEmployees = engineeringDept.SearchEmployee(name);
                if (engineeringEmployees.Count > 0)
                {
                    engineeringDept.RemoveEmployee(engineeringEmployees[0]);
                    Console.WriteLine($"Employee {name} removed from Engineering department.");
                }
                else
                {
                    Console.WriteLine($"Employee {name} not found in Engineering department.");
                }
                break;
            case 2:
                var salesEmployees = salesDept.SearchEmployee(name);
                if (salesEmployees.Count > 0)
                {
                    salesDept.RemoveEmployee(salesEmployees[0]);
                    Console.WriteLine($"Employee {name} removed from Sales department.");
                }
                else
                {
                    Console.WriteLine($"Employee {name} not found in Sales department.");
                }
                break;
            default:
                Console.WriteLine("Invalid choice! Employee not removed.");
                break;
        }
    }

    static void DisplayEmployees(Department engineeringDept, Department salesDept)
    {
        engineeringDept.DisplayEmployees();
        salesDept.DisplayEmployees();
    }

    static void CalculateTotalSalaries(Department engineeringDept, Department salesDept)
    {
        Console.WriteLine($"Total salaries in {engineeringDept.Name}: {engineeringDept.CalculateTotalSalaries():C}");
        Console.WriteLine($"Total salaries in {salesDept.Name}: {salesDept.CalculateTotalSalaries():C}");
    }

    static void GiveRaiseToAll(Department engineeringDept, Department salesDept)
    {
        Console.Write("Enter raise amount: ");
        double raiseAmount = double.Parse(Console.ReadLine());
        engineeringDept.GiveRaiseToAll(raiseAmount);
        salesDept.GiveRaiseToAll(raiseAmount);
        Console.WriteLine("Raise given to all employees.");
    }

    static void SearchEmployee(Department engineeringDept, Department salesDept)
    {
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        bool found = false;

        foreach (var employee in engineeringDept.Employees)
        {
            if (employee.Name.ToLower().Contains(name.ToLower()))
            {
                Console.WriteLine("Found in Engineering department:");
                Console.WriteLine($"- {employee}");
                found = true;
            }
        }

        foreach (var employee in salesDept.Employees)
        {
            if (employee.Name.ToLower().Contains(name.ToLower()))
            {
                Console.WriteLine("Found in Sales department:");
                Console.WriteLine($"- {employee}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine($"Employee {name} not found in any department.");
        }
    }




}
