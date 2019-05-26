using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Worker
    {
        public string Name { get; set; }
        public int WorkPosition { get; set; }
        public Worker(string name, int workPosition)
        {
            Name = name;
            WorkPosition = workPosition;
        }
    }
}
