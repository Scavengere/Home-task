using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string text = Console.ReadLine();
            Console.ResetColor();
            text = TextTransformer.CheckEnteredString(text);
            Console.Write($"After transformer: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(text);
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
