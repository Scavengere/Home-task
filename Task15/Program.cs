using System;
using System.Diagnostics;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            int res;
            stopwatch.Start();
            res = GCD.Algorithm1(81, 135);
            stopwatch.Stop();
            Console.WriteLine(res);
            Console.WriteLine(stopwatch.Elapsed);

            stopwatch.Start();
            res = GCD.Algorithm2(81, 135);
            stopwatch.Stop();
            Console.WriteLine(res);
            Console.WriteLine(stopwatch.Elapsed);

            stopwatch.Start();
            res = GCD.Algorithm3(81, 135);
            stopwatch.Stop();
            Console.WriteLine(res);
            Console.WriteLine(stopwatch.Elapsed);

            Console.ReadLine();
        }
    }
}
