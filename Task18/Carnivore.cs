using System;
using System.Threading;

namespace Task18
{
    class Carnivore
    {
        public delegate void CarnivoreHandler(string message);
        public event CarnivoreHandler EatHerbivore;

        public string KindOfCarnivore { set; get; }
        public bool IsEaten { get; private set; }

        public Carnivore(string kindOfCarnivore)
        {
            IsEaten = false;
            KindOfCarnivore = kindOfCarnivore;
        }

        public void Eating(string herbivore)
        {
            while (!IsEaten)
            {
                int n = Program.random.Next(1, 11);
                if (n >= 1 && n < 4)
                {
                    IsEaten = true;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    EatHerbivore?.Invoke($"{herbivore} has been eaten by {KindOfCarnivore}");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                }
                else
                {
                    EatHerbivore?.Invoke($"{herbivore} escaped from {KindOfCarnivore}");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
