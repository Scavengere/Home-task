using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    abstract class Human
    {
        protected string Name { get; set; }
        protected int Age { get; set; }
        protected string Sex { get; set; }
        public abstract void GoSleep();
        public abstract void GoEat();
        public abstract void LeisureTime();
        public abstract void OutputInformation();
    }
}