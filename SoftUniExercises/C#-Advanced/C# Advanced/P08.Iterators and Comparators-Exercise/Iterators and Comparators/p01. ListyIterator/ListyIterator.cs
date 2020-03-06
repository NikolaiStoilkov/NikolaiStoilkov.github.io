using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComperators
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> data;
        public int _index = 0;
        public T Line { get; set; }
        public ListyIterator()
        {
            this.data = new List<T>();
        }
        public void Create(T input)
        {
            this.data.Add(input);
        }
        public bool Move()
        {
            if ((_index + 1) < this.data.Count)
            {
                _index++;
                return true;
            }

            return false;
        }
        public bool HasNext()
        {
            if (_index < this.data.Count)
            {
                return true;
            }

            return false;
        }
        public void Print()
        {
            if (this.data.Count <= 0)
            {
                throw new InvalidOperationException(
                    "Invalid Operation!"
                );
            }
            else
            {
                Console.WriteLine($"{this.data[_index]}");
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
