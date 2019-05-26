using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("Иванов", 41);
            Worker worker2 = new Worker("Павлюк", 12);
            Worker worker3 = new Worker("Фролов", 26);
            Crew crew = new Crew
            {
                worker1,
                worker2,
                worker3
            };
            crew.Sort();
            foreach (Worker worker in crew)
            {
                Console.WriteLine(worker.Name + " " + worker.WorkPosition);
            }
            Console.ReadLine();
        }
    }
}
