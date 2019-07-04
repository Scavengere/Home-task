using System;
using System.Collections.Generic;

namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>();
            Console.WriteLine("Input number of workers");
            try
            {
                int n = Convert.ToInt16(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Input name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Input age");
                    int age = Convert.ToInt16(Console.ReadLine());
                    Worker worker = new Worker(name, age);
                    workers.Add(worker);
                }
                foreach (Worker w in workers)
                {
                    Console.WriteLine($"Name: {w.Name}; Age: {w.Age}");
                }
            }
            catch (AgeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Uncorrect value: {ex.Age}");
            }
            catch (NameException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Uncorrect value: {ex.Name}");
            }
            Console.ReadLine();
        }
    }
}
