using System;
using System.Collections;
using System.Collections.Generic;

namespace Task12
{
    class CrewEnumerator : IEnumerator<Worker>
    {
        private Crew crew;
        private int position = -1;

        public CrewEnumerator(Crew workers)
        {
            crew = workers;
            Current = default(Worker);
        }

        public Worker Current { get; private set; }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public bool MoveNext()
        {
            if (++position >= crew.Count)
            {
                return false;
            }
            else
            {
                Current = crew[position];
            }
            return true;
        }

        public void Reset()
        {
            position = -1;
        }

        void IDisposable.Dispose()
        {

        }
    }
}
