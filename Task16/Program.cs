using System;
using System.Threading;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread threadAlgorithm2 = new Thread(() => { GCD.Algorithm2(81, 135); });
            Thread threadAlgorithm3 = new Thread(() => { GCD.Algorithm3(81, 135); });
            threadAlgorithm2.Start();
            threadAlgorithm3.Start();
            GCD.Algorithm1(81, 135);
            threadAlgorithm2.Join();
            threadAlgorithm3.Join();
            Console.ReadKey();
        }
    }
}
