using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodStrings
{

    public class Box<T> where T : IComparable
    {
        private T data;
        List<T> values = new List<T>();

        public Box()
        {
        }

        public T Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }

        public void AddValue(T value)
        {
            values.Add(value);
        }

        public int CountOfValues(List<T> itemToCompare, T compareItem)
        {
            int cnt = 0;

            foreach (var value in itemToCompare)
            {
                if (compareItem.CompareTo(value) < 0)
                {
                    cnt++;
                }

            }

            return cnt;
        }

       

    }
}
