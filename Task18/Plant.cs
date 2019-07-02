using System;
using System.Threading;

namespace Task18
{
    class Plant
    {
        public delegate void PlantHandler(string message);
        public event PlantHandler Grow;

        public string KindOfPlant { set; get; }
        public bool IsGrown { get; private set; }

        public Plant(string kindOfPlant)
        {
            IsGrown = false;
            KindOfPlant = kindOfPlant;
        }
        public void Grows()
        {
            int n = Program.random.Next(1, 11);
            for (int i = 0; i < n; i++)
            {
                Grow?.Invoke($"{KindOfPlant} grows");
                Thread.Sleep(1000);
            }
        }
        public void HasGrown()
        {
            IsGrown = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Grow?.Invoke($"{KindOfPlant} has grown");
            Console.ResetColor();
        }
    }
}
