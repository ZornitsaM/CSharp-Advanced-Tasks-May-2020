using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> elements;
        private int index;

        public ListyIterator(List<T> elements)
        {
            this.elements = elements;
            this.index = 0;
        }

        public bool Move()
        {
            bool hasNext = this.HasNext();

            if (hasNext)
            {
                this.index++;
            }
            return hasNext;
        }

        public void Print()
        {
            if (this.elements.Count > 0)
            {
                Console.WriteLine(this.elements[this.index]);
            }
            else
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
        }

        public bool HasNext()
        {
            if (this.index < this.elements.Count - 1)
            {
                return true;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.elements)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
