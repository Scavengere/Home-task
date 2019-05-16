using System;
using System.Collections.Generic;
using System.Linq;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Bear bear1          = new Bear("Миша", 10, "M",TypeOfAnimalNutrition.Carnivorous, DistributionZone.Forest, rand);
            Bear bear2          = new Bear("Настя", 9, "F", TypeOfAnimalNutrition.Carnivorous, DistributionZone.Forest, rand);
            Elephant elephant1  = new Elephant("Лунтик", 5, "F", TypeOfAnimalNutrition.Herbivorous, DistributionZone.Savannah, rand);
            Elephant elephant2  = new Elephant("Чебурашка", 12, "M", TypeOfAnimalNutrition.Herbivorous, DistributionZone.Savannah, rand);
            Monkey monkey1      = new Monkey("Фокся", 2, "F", TypeOfAnimalNutrition.Herbivorous, DistributionZone.Jungle, rand);
            Monkey monkey2      = new Monkey("Света", 6, "F", TypeOfAnimalNutrition.Herbivorous, DistributionZone.Jungle, rand);
            Wolf wolf1          = new Wolf("Маркиз", 3, "M", TypeOfAnimalNutrition.Carnivorous, DistributionZone.Forest, rand);
            Wolf wolf2          = new Wolf("Максим", 6, "M", TypeOfAnimalNutrition.Carnivorous, DistributionZone.Forest, rand);
            Cat cat1            = new Cat("Кот", 2, "M", Products.None, LevelOfProfit.None, rand);
            Cat cat2            = new Cat("Мурка", 4, "F", Products.None, LevelOfProfit.None, rand);
            Chicken chicken1    = new Chicken("Маша", 2, "F", Products.Eggs, LevelOfProfit.High, rand);
            Chicken chicken2    = new Chicken("Даша", 1, "F", Products.Eggs, LevelOfProfit.High, rand);
            Chicken chicken3    = new Chicken("Наташа", 3, "F", Products.Eggs, LevelOfProfit.Low, rand);
            Cow cow1            = new Cow("Буренка", 6, "F", Products.Milk, LevelOfProfit.High, rand);
            Cow cow2            = new Cow("Алеша", 2, "M", Products.None, LevelOfProfit.None, rand);
            
            Group<IAnimal> allAnimal = new Group<IAnimal>();
            allAnimal.Animals.Add(bear1);
            allAnimal.Animals.Add(bear2);
            allAnimal.Animals.Add(elephant1);
            allAnimal.Animals.Add(elephant2);
            allAnimal.Animals.Add(monkey1);
            allAnimal.Animals.Add(monkey2);
            allAnimal.Animals.Add(wolf1);
            allAnimal.Animals.Add(wolf2);
            allAnimal.Animals.Add(cat1);
            allAnimal.Animals.Add(cat2);
            allAnimal.Animals.Add(chicken1);
            allAnimal.Animals.Add(chicken2);
            allAnimal.Animals.Add(chicken3);
            allAnimal.Animals.Add(cow1);
            allAnimal.Animals.Add(cow2);
            Console.WriteLine("Output all animals:");
            allAnimal.OutputAllAnimals();

            Console.WriteLine("\nOutput only male animals:");
            var result0 = from animal in allAnimal.Animals
                          where animal.Sex == "M"
                          select animal;
            foreach (IAnimal animal in result0)
                Console.WriteLine($"{animal.ToString().Remove(0, 7)}  {animal.Name}  {animal.Age}  {animal.Sex} {animal.CurrentOccupation}");
            
            Group<WildAnimal> wildAnimals = new Group<WildAnimal>();
            wildAnimals.Animals.Add(bear1);
            wildAnimals.Animals.Add(bear2);
            wildAnimals.Animals.Add(elephant1);
            wildAnimals.Animals.Add(elephant2);
            wildAnimals.Animals.Add(monkey1);
            wildAnimals.Animals.Add(monkey2);
            wildAnimals.Animals.Add(wolf1);
            wildAnimals.Animals.Add(wolf2);
            Console.WriteLine("\nOutput all wild animals:");
            foreach (WildAnimal animal in wildAnimals.Animals)
                Console.WriteLine($"{animal.ToString().Remove(0, 7)}  {animal.Name}  {animal.Age}  {animal.Sex} {animal.CurrentOccupation} {animal.DistributionZone} {animal.TypeOfAnimalNutrition}");
            
            Console.WriteLine("\nOutput forest wild animals ordered by age:");
            var result1 = from animal in wildAnimals.Animals
                          where animal.DistributionZone == DistributionZone.Forest
                          orderby animal.Age
                          select animal;
            foreach (WildAnimal animal in result1)
                Console.WriteLine($"{animal.ToString().Remove(0, 7)}  {animal.Name}  {animal.Age}  {animal.Sex} {animal.CurrentOccupation} {animal.DistributionZone} {animal.TypeOfAnimalNutrition}");

            Console.WriteLine("\nOutput wild carnivorous animals ordered by decreasing age:");
            var result2 = from animal in wildAnimals.Animals
                          where animal.TypeOfAnimalNutrition == TypeOfAnimalNutrition.Carnivorous
                          orderby animal.Age descending
                          select animal;
            foreach (WildAnimal animal in result2)
                Console.WriteLine($"{animal.ToString().Remove(0, 7)}  {animal.Name}  {animal.Age}  {animal.Sex} {animal.CurrentOccupation} {animal.DistributionZone} {animal.TypeOfAnimalNutrition}");

            Group<HomeAnimal> homeAnimals = new Group<HomeAnimal>();
            homeAnimals.Animals.Add(cat1);
            homeAnimals.Animals.Add(cat2);
            homeAnimals.Animals.Add(chicken1);
            homeAnimals.Animals.Add(chicken2);
            homeAnimals.Animals.Add(chicken3);
            homeAnimals.Animals.Add(cow1);
            homeAnimals.Animals.Add(cow2);
            Console.WriteLine("\nOutput all home animals:");
            foreach (HomeAnimal animal in homeAnimals.Animals)
                Console.WriteLine($"{animal.ToString().Remove(0, 7)}  {animal.Name}  {animal.Age}  {animal.Sex} {animal.CurrentOccupation} {animal.Products} {animal.Profit}");

            Console.WriteLine("\nOutput home animals that produce nothing:");
            var result3 = from animal in homeAnimals.Animals
                          where animal.Profit == LevelOfProfit.None
                          select animal;
            foreach (HomeAnimal animal in result3)
                Console.WriteLine($"{animal.ToString().Remove(0, 7)}  {animal.Name}  {animal.Age}  {animal.Sex} {animal.CurrentOccupation} {animal.Products} {animal.Profit}");
            
            Console.WriteLine("\nOutput chicken with high profit:");
            var result4 = from animal in homeAnimals.Animals
                          where animal.Products == Products.Eggs && animal.Profit == LevelOfProfit.High
                          select animal;
            foreach (HomeAnimal animal in result4)
                Console.WriteLine($"{animal.ToString().Remove(0, 7)}  {animal.Name}  {animal.Age}  {animal.Sex} {animal.CurrentOccupation} {animal.Products} {animal.Profit}");
            
            Console.ReadKey();
        }
    }
}
