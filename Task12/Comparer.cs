using System.Collections.Generic;

namespace Task12
{
    class Comparer : IComparer<Worker>
    {
        public int Compare(Worker x, Worker y)
        {
            if (x.WorkPosition > y.WorkPosition)
                return 1;
            if (x.WorkPosition < y.WorkPosition)
                return -1;
            else return 0;
        }
    }
}
