using System;

namespace Task15
{
    class GCD
    {
        public static int Algorithm1(int number1, int number2)
        {
            while (number1 != 0 && number2 != 0)
                if (number1 > number2)
                    number1 %= number2;
                else
                    number2 %= number1;
            return number1 + number2;
        }
        public static int Algorithm2(int number1, int number2)
        {
            if (number2 == 0)
                return number1;
            return Algorithm2(number2, number1 % number2);
        }
        public static int Algorithm3(int number1, int number2)
        {
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
            return number1;
        }

    }
}

