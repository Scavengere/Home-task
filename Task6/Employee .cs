using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task6
{
    class Employee
    {
        public string NameOfEmployee { get; set; }
        public int EmployeeSalary { get; set; }
        public Employee()
        {
            NameOfEmployee = "";
            EmployeeSalary = 0;
        }
        public Employee(string name, int salary)
        {
            NameOfEmployee = name;
            EmployeeSalary = salary;
        }
        static public void Output(Employee[] array)
        {
            foreach (Employee employee in array)
                Console.WriteLine($"{employee.NameOfEmployee}   {employee.EmployeeSalary};");
        }
        static public Employee[] SortingBySalary(Employee[] array)
        {
            Employee temp = new Employee();
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                    if(array[i].EmployeeSalary > array[j].EmployeeSalary)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
            }
            return array;
        }
        static public Employee[] SortingByName(Employee[] array)
        {
            Employee temp = new Employee();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                    if ((String.Compare(array[i].NameOfEmployee,array[j].NameOfEmployee) > 0))
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
            }
            return array;
        }

    }
}
