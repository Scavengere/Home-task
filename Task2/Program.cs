using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            InputNumberOfEmployees(out int numberOfEmployees);
            Employee[] employees = new Employee[numberOfEmployees];
            for (int i = 0; i < numberOfEmployees; i++)
            {
                InputInformation(out string name, out int salary);
                employees[i] = new Employee(name, salary);
            }
            Console.Clear();
            Console.WriteLine("Employees: ");
            Employee.Output(employees);
            Console.WriteLine("\nSorting by salary: ");
            Employee.SortingBySalary(employees);
            Employee.Output(employees);
            Console.WriteLine("\nSorting by name: ");
            Employee.SortingByName(employees);
            Employee.Output(employees);
            
            Console.ReadKey();
        }
        static public void InputNumberOfEmployees(out int numberOfEmployees)
        {
            int temp = 0;
            bool successfulInput = false;
            while (successfulInput == false)
            {
                try
                {
                    Console.WriteLine("Enter the number of employees: ");
                    temp = Int32.Parse(Console.ReadLine());
                    successfulInput = true;
                }
                catch (FormatException)
                {
                    Console.Write("You entered a variable of the wrong type. Press any button to repeat...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            numberOfEmployees = temp;
        }
        static public void InputInformation(out string name, out int salary)
        {
            string tempName = "";
            int tempSalary = 0;
            bool successfulInput = false;
            while (successfulInput == false)
            {
                try
                {
                    Console.WriteLine("Enter the name of employee: ");
                    tempName = Console.ReadLine();
                    Console.WriteLine("Enter the salary of employee: ");
                    tempSalary = Int32.Parse(Console.ReadLine());
                    successfulInput = true;
                }
                catch (FormatException)
                {
                    Console.Write("You entered a variable of the wrong type. Press any button to repeat...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            name = tempName;
            salary = tempSalary;
        }
    }
}
