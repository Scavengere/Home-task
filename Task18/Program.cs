using System;

namespace Task18
{
    class Program
    {
        public static Random random = new Random();
        static void Main(string[] args)
        {
            Plant wheat = new Plant("Wheat");
            Herbivore mouse = new Herbivore("Mouse");
            Carnivore cat = new Carnivore("Cat");
            wheat.Grow += ShowMessage;
            wheat.Grows();
            wheat.HasGrown();
            if (wheat.IsGrown)
            {
                mouse.EatPlant += ShowMessage;
                mouse.Eating(wheat.KindOfPlant);
                mouse.HasEaten(wheat.KindOfPlant);
            }
            if (mouse.IsEaten)
            {
                cat.EatHerbivore += ShowMessage;
                cat.Eating(mouse.KindOfHerbivore);
            }
            Console.ReadLine();
        }
        private static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
