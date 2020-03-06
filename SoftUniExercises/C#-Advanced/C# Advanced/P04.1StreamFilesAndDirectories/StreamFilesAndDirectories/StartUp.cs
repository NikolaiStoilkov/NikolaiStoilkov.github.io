using System;
using System.IO;
using System.Linq;
using System.Text;

namespace StreamFilesAndDirectories
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // string path = "../../../Input.txt";
            char[] charToReplace = new char[] { '-', ',', '.', '!', '?' };

            StreamReader streamReader = new StreamReader("./Input.txt");

            int cnt = 0;
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();

                if (line == null)
                {
                    break;
                }

                if (cnt % 2 == 0)
                {

                    line = ReplaceAll(charToReplace, '@',line);

                    line = String.Join(' ', line
                        .Split(' ')
                        .Reverse());

                    Console.WriteLine(line);
                }

                cnt++;
            }


        }

        public static string ReplaceAll(char[] replace , char replacement,string str)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                char currSymbol = str[i];

                if (replace.Contains(currSymbol))
                {
                    sb.Append('@');
                }
                else
                {
                    sb.Append(currSymbol);
                }

            }
                return sb.ToString().TrimEnd();
        }
    }
}
