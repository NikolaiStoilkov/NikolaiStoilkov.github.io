using System;
using System.Collections.Generic;
using System.Text;

namespace p03
{
    public class Swap<T>
    {
        private T name;

        private T temp;
        public List<T> Names { get; set; }

       public void SwapNames(List<T> names,int firstIndex , int secondIndex)
        {
            this.Names = names;
            temp = Names[firstIndex];
            Names[firstIndex] = Names[secondIndex];
            Names[secondIndex] = temp;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.Names)
            {
                sb.AppendLine($"{item.GetType()}: {item.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
