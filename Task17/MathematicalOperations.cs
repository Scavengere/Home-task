using System;
using System.Collections.Generic;
using MathNet.Numerics.Statistics;
using System.Linq;
namespace Task17
{
    class MathematicalOperations
    {
        public static void Menu(List<double> data)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Your data:");
                foreach (double number in data)
                    Console.Write(number + " ");
                Console.WriteLine("\n");
                OutoutMenu();
                int choose = Convert.ToInt16(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        {
                            Console.WriteLine($"Result = {data.Sum()}");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"Maximum = {data.Maximum()}; Minimum = {data.Minimum()}");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Mean = {data.Mean()}");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"Median = {data.Median()}");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine($"Variance = {data.Variance()}");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Input tau [0,0 - 1,0]");
                            Console.WriteLine($"Quantile = {data.Quantile(Convert.ToDouble(Console.ReadLine()))}");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            break;
                        }
                    case 7:
                        {
                            return;
                        }
                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Incorrect input!\nPress any key to repeat");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                        }
                }
            }
        }
        public static void OutoutMenu()
        {
            Console.WriteLine(
                   "Choose operation:\n" +
                   "1 Sum\n" +
                   "2 Maximum and minimum\n" +
                   "3 Mean\n" +
                   "4 Median\n" +
                   "5 Variance\n" +
                   "6 Quantile\n" +
                   "7 Exit"
                );
        }
    }
}
