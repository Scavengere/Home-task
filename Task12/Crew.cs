using System.Collections;
using System.Collections.Generic;

namespace Task12
{
    class Crew : IList<Worker>
    {
        private List<Worker> workers;
        
        public int Count
        {
            get
            {
                return workers.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }
        
        public Worker this[int i]
        {
            get
            {
                return workers[i];
            }
            set
            {
                workers[i] = value;
            }
        }

        public Crew()
        {
            workers = new List<Worker>();
        }

        public void Add(Worker value)
        {
            workers.Add(value);
        }

        public int IndexOf(Worker value)
        {
            return workers.IndexOf(value);
        }

        public void Insert(int i, Worker value)
        {
            workers.Insert(i, value);
        }

        public bool Remove(Worker value)
        {
           return workers.Remove(value);
        }

        public void RemoveAt(int i)
        {
            workers.RemoveAt(i);
        }

        public void Clear()
        {
            workers.Clear();
        }

        public bool Contains(Worker value)
        {
            return workers.Contains(value);
        }

        public void CopyTo(Worker[] a, int i)
        {
            for (int k = 0; k < workers.Count; k++)
            {
                a[k + i] = workers[i];
            }
        }

        public IEnumerator<Worker> GetEnumerator()
        {
            return new CrewEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new CrewEnumerator(this);
        }

        public void Sort()
        {
            Comparer comp = new Comparer();
            workers.Sort(comp);
        }
    }
}
