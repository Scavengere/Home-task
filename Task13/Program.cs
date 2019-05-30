using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input email");
            string email = Console.ReadLine();
            Console.WriteLine(Validation.ValidateEmail(email));
            Console.WriteLine("Input url");
            string url = Console.ReadLine();
            Console.WriteLine(Validation.ValidateURL(url));
            Console.WriteLine("Input path");
            string path = Console.ReadLine();
            Console.WriteLine(Validation.ValidatFilePath(path));
            Console.ReadLine();
        }
    }
}
