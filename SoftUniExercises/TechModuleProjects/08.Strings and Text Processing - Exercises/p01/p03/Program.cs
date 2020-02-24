using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace p03
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";

            Console.WriteLine(GetUniCode(text));

        }

        private static string GetUniCode(string text)
        {
            text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            foreach (char c in text)
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:x4}", (int)c));
            }
            return sb.ToString();
        }
    }
}
