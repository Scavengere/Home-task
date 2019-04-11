using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Boy : Human
    {
        public bool HaveAGirlfriend { get; set; }
        public string NameOfGirlfriend { get; set; }
        public string Status { get; set; }
        public Boy()
        {
            Name = "-";
            Age = 0;
            Sex = "Boy";
            HaveAGirlfriend = false;
            NameOfGirlfriend = "-";
            Status = "-";
        }
        public Boy(string name, int age, bool haveAGirlfrien = false, string nameOfGirlfriend = "-")
        {
            Name = name;
            Age = age;
            Sex = "Boy";
            HaveAGirlfriend = haveAGirlfrien;
            NameOfGirlfriend = "-";
            if (haveAGirlfrien)
                NameOfGirlfriend = nameOfGirlfriend;
            Status = "-";
        }

        public override void GoSleep()
        {
            Console.WriteLine($"{Name} goes to sleep.");
            Status = "Sleeping";
        }

        public override void GoEat()
        {
            Console.WriteLine($"{Name} goes to eat.");
            Status = "Eating";
        }
        public override void LeisureTime()
        {
        Random rand = new Random();
        int randomrandomAction = rand.Next(0,5);
            switch (randomrandomAction)
            {
                case 0:
                    GoSleep();
                    break;
                case 1:
                    GoReadBook();
                    break;
                case 2:
                    GoPlayComputerGames();
                    break;
                case 3:
                    GoPlayFootball();
                    break;
                case 4:
                    WriteToYourGirlfriend();
                    break;
            }
        }
        public void GoReadBook()
        {
            Console.WriteLine($"{Name} goes to read a book.");
            Status = "Read book";
        }
        public void GoPlayComputerGames()
        {
            Console.WriteLine($"{Name} goes to play a computer game.");
            Status = "Playing computer games";
        }
        public void GoPlayFootball()
        {
            Console.WriteLine($"{Name} goes to play football.");
            Status = "Playing football";
        }
        public void WriteToYourGirlfriend()
        {
            if(HaveAGirlfriend)
            {
                Console.WriteLine($"{Name} writes {NameOfGirlfriend}.");
                Status = "Write his girlfriend";
            }
            else
            {
                Console.WriteLine($"The {Name} has not a girlfriend.");
                Status = "Trying to write non-existent girlfriend.";
            }
        }
        public override void OutputInformation()
        {
            Console.WriteLine($"{Name}  {Sex}  {Age}  {Status}  {HaveAGirlfriend}  {NameOfGirlfriend}");
        }
    }
}
