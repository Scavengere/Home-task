using System;

namespace Task10
{
    class Wolf : WildAnimal, ICanEat, ICanMove, ICanSleep
    {
        public Wolf()
        {
            Name = "";
            Age = 0;
            Sex = "";
        }
        public Wolf(string name, int age, string sex, TypeOfAnimalNutrition typeOfAnimalNutrition, DistributionZone distributionZone, Random rand)
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
            Console.WriteLine("Wolf is eating.");
        }

        public void Move()
        {
            Console.WriteLine("Wolf is moving.");
        }

        public void Sleep()
        {
            Console.WriteLine("Wolf is sleeping.");
        }
    }
}
