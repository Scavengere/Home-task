using System;

namespace Task10
{
    class Bear : WildAnimal, ICanEat, ICanMove, ICanSleep
    {
        public Bear()
        {
            Name = string.Empty;
            Age = 0;
            Sex = string.Empty;
        }
        public Bear(string name, int age, string sex, TypeOfAnimalNutrition typeOfAnimalNutrition, DistributionZone distributionZone, Random rand)
        {
            Name = name;
            Age = age;
            Sex = sex;
            TypeOfAnimalNutrition = typeOfAnimalNutrition;
            DistributionZone = distributionZone;
            CurrentOccupation = (Status)rand.Next(0, 3);
        }
        public void Eat()
        {
            Console.WriteLine("Bear is eating.");
        }
        public void Move()
        {
            Console.WriteLine("Bear is moving.");
        }
        public void Sleep()
        {
            Console.WriteLine("Bear is sleeping.");
        }
    }
}
