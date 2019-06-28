using System;
using System.Diagnostics;

namespace Task16
{
    class GCD
    {
        public static void Algorithm1(int number1, int number2)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (number1 != 0 && number2 != 0)
                if (number1 > number2)
                    number1 %= number2;
                else
                    number2 %= number1;
            stopwatch.Stop();
            Console.WriteLine("Algorithm1: result - {0}  time - {1}", number1 + number2, stopwatch.Elapsed);
        }
        public static void Algorithm2(int number1, int number2)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int result = _Algorithm2(number1, number2);
            stopwatch.Stop();
            Console.WriteLine("Algorithm2: result - {0}  time - {1}", result, stopwatch.Elapsed);
        }
        public static int _Algorithm2(int number1, int number2)
        {
            if (number2 == 0)
                return number1;
            return _Algorithm2(number2, number1 % number2);
        }
        public static void Algorithm3(int number1, int number2)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (number1 != number2)
            {
                if (number1 > number2)
                {
                    int tmp = number1;
                    number1 = number2;
                    number2 = tmp;
                }
                number2 = number2 - number1;
            }
            stopwatch.Stop();
            Console.WriteLine("Algorithm3: result - {0}  time - {1}", number1, stopwatch.Elapsed);
        }
    }
}
