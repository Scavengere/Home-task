using System;
using System.Collections.Generic;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input size of data");
            try
            {
                int n = Convert.ToInt16(Console.ReadLine());
                List<double> data = new List<double>();
                Console.WriteLine("Input data");
                for (int i = 0; i < n; i++)
                    data.Add(Convert.ToDouble(Console.ReadLine()));

                MathematicalOperations.Menu(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
