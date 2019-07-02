using System;
using System.Threading;

namespace Task18
{
    class Herbivore
    {
        public delegate void HerbivoreHandler(string message);
        public event HerbivoreHandler EatPlant;

        public string KindOfHerbivore { set; get; }
        public bool IsEaten { get; private set; }

        public Herbivore(string kindOfHerbivore)
        {
            IsEaten = false;
            KindOfHerbivore = kindOfHerbivore;
        }
        public void Eating(string plant)
        {
            int n = Program.random.Next(1, 6);
            for (int i = 0; i < n; i++)
            {
                EatPlant?.Invoke($"{KindOfHerbivore} is eating {plant}");
                Thread.Sleep(1000);
            }
        }
        public void HasEaten(string plant)
        {
            IsEaten = true;
            Console.ForegroundColor = ConsoleColor.Green;
            EatPlant?.Invoke($"{plant} has been eaten by {KindOfHerbivore}");
            Console.ResetColor();
        }
    }
}
