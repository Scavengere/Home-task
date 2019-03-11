using System;

namespace Task1
{
    class Student
    {
        public string nameOfStudent;
        public int ageOfStudent;
        public int numberOfSubject;
        public Mark[] Marks;
        public Student(string Name, int Age)
        {
            nameOfStudent = Name;
            ageOfStudent = Age;
        }
        public void IntroductionOfSubjects()
        {
            Console.Write("Enter the number of subject: ");
            numberOfSubject = Convert.ToInt32(Console.ReadLine());
            Marks = new Mark[numberOfSubject];

            for (int i = 0; i < numberOfSubject; i++)
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
            Console.WriteLine($"Name - {student.nameOfStudent}\nAge - {student.ageOfStudent}");
            for (int i = 0; i < student.numberOfSubject; i++)
            {
                Console.WriteLine($"Subject - {student.Marks[i].nameOfSubject} ------ Mark - {student.Marks[i].mark}");
            }
        }
        public double GetAvgMark()
        {
            double avgMark = 0;
            for (int i = 0; i < numberOfSubject; i++)
                avgMark += Marks[i].mark;
            avgMark /= numberOfSubject;
            return avgMark;
        }
        public void ResetAllMarks()
        {
            for (int i = 0; i < numberOfSubject; i++)
                Marks[i].mark = 0;
        }
    }
}
