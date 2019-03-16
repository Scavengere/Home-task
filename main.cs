using System;

namespace Task1
{
    class main
    {
        static void Main(string[] args)
        {
            Student.InputName(out string Name);
            Student.InputAge(out int Age);

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
