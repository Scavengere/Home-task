using System;

namespace Task1
{
    class main
    {
        static void Main(string[] args)
        {
            string Name;
            int Age;
            Console.Write("Enter name of student: ");
            Name = Console.ReadLine();
            Console.Write("Enter age of student: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Student first = new Student(Name, Age);
            first.IntroductionOfSubjects();
            Console.Clear();

            Student.OutputInformationOfStudent(first);
            Console.WriteLine($"\nAverage mark: {first.GetAvgMark()}\n");
            first.ResetAllMarks();
            Student.OutputInformationOfStudent(first);
            Console.ReadKey();
        }
        
    }
}
