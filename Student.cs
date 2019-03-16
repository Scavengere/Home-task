using System;

namespace Task1
{
    class Student
    {
        public string NameOfStudent { get; set; }
        public int AgeOfStudent { get; set; }
        public int NumberOfSubject { get; set; }
        public Mark[] Marks;
 
        public Student(string Name, int Age)
        {
            NameOfStudent = Name;
             AgeOfStudent = Age;
        }
        public void IntroductionOfSubjects()
        {
            loop1:
            Console.Write("Enter the number of subject: ");
            try
            {
                NumberOfSubject = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.Write("You entered a variable of the wrong type. Press any button to repeat...");
                Console.ReadKey();
                Console.Clear();
                goto loop1;
            }
            if(NumberOfSubject > 5)
            {
                Console.Write("Students cannot study more than 5 subjects. Press any button to repeat...");
                Console.ReadKey();
                Console.Clear();
                goto loop1;
            }
            if(NumberOfSubject < 1)
            {
                Console.Write("You have entered the number of items less than 1. Press any button to repeat...");
                Console.ReadKey();
                Console.Clear();
                goto loop1;
            }
            Marks = new Mark[NumberOfSubject];

            for (int i = 0; i < NumberOfSubject; i++)
            {
                Marks[i] = new Mark();
                Console.Write("Enter subject name: ");
                Marks[i].nameOfSubject = Console.ReadLine();
                Console.Write("Enter a mark: ");
                Marks[i].mark = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void OutputInformationOfStudent(Student student)
        {
            Console.WriteLine($"Name - {student.NameOfStudent}\nAge - {student.AgeOfStudent}");
            for (int i = 0; i < student.NumberOfSubject; i++)
            {
                Console.WriteLine($"Subject - {student.Marks[i].nameOfSubject} ------ Mark - {student.Marks[i].mark}");
            }
        }
        public double GetAvgMark()
        {
            double avgMark = 0;
            for (int i = 0; i < NumberOfSubject; i++)
                avgMark += Marks[i].mark;
            avgMark /= NumberOfSubject;
            return avgMark;
        }
        public void ResetAllMarks()
        {
            for (int i = 0; i < NumberOfSubject; i++)
                Marks[i].mark = 0;
        }
        
        static public void InputName(out string Name)
        {
            Console.Write("Enter name of student: ");
            Name = Console.ReadLine();
            Console.Clear();
        }
        static public void InputAge(out int Age)
        {
        loop1:
            Console.Write("Enter age of student: ");
            try
            {
                Age = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Write("You entered a variable of the wrong type. Press any button to repeat...");
                Console.ReadKey();
                Console.Clear();
                goto loop1;
            }
            if (Age > 0)
            {
                if (Age < 18)
                {
                    Console.WriteLine("Persons younger 18 are not allowed. Press any button to repeat...");
                    Console.ReadKey();
                    Console.Clear();
                    goto loop1;
                }
            }
            else
            {
                Console.WriteLine("You entered a negative age. Press any button to repeat...");
                Console.ReadKey();
                Console.Clear();
                goto loop1;
            }
        }
    }
}
