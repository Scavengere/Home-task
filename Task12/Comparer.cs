using System.Collections.Generic;

namespace Task12
{
    class Comparer : IComparer<Worker>
    {
        public int Compare(Worker x, Worker y)
        {
            if (x.WorkPosition.CompareTo(y.WorkPosition) > 0)
                return 1;
            if (x.WorkPosition.CompareTo(y.WorkPosition) < 0)
                return -1;
            else return 0;
        }
    }
}
