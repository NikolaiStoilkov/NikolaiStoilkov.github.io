using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodStrings
{

    public class Box<T>
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

        public int CountOfValues(string itemToCompare)
        {
            int cnt = 0;

            foreach (var value in values)
            {
                var firstL = itemToCompare
                    .Length;

                var secondL = value
                    .ToString()
                    .Length;

                if (firstL == secondL)
                {
                    cnt++;
                }
            }

            return cnt;
        }

       

    }
}
