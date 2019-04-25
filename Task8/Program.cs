using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path:");
            string path = Console.ReadLine();
            try
            {
                WorkingWithFile.ShowAllFilesInDirectory(path);
                Console.WriteLine("Enter name of file for reading information:");
                string nameOfFile = Console.ReadLine();
                WorkingWithFile.ShowFileContent(path, nameOfFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
