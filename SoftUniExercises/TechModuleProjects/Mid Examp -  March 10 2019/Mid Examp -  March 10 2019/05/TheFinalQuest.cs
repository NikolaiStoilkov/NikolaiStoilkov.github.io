using System;
using System.Linq;
using System.Collections.Generic;

namespace _03
{
    class TheFinalQuest
    {
        static void Main(string[] args)
        {
            List<string> word = Console.ReadLine()
                .Split()
                .ToList();
            string savedDelete = string.Empty;
            string command = Console.ReadLine();

            string[] typeArr = command.Split()
                   .ToArray();

            while (typeArr[0] != "Stop")
            {
                if (typeArr[0] == "Delete")
                {
                    int getIndex = int.Parse(typeArr[1]) + 1;

                    savedDelete += word[getIndex] + ' ' + getIndex;
                    word.RemoveAt(getIndex);
                }
                else if (typeArr[0] == "Swap")
                {
                    bool getFirst = false;
                    bool getSecond = false;

                    string firstWord = string.Empty;
                    string secondWord = string.Empty;

                    int indexOfFrist = 0;
                    int indexOfSecond = 0;

                    for (int i = 0; i < word.Count; i++)
                    {
                        if (word.Contains(typeArr[1]) && getFirst == false)
                        {
                            firstWord = typeArr[1];

                            indexOfFrist = GetIndexOfList(word, typeArr[1]);
                            getFirst = true;
                            break;
                        }
                    }

                    for (int i = 0; i < word.Count; i++)
                    {
                        if (word.Contains(typeArr[2]) && getSecond == false)
                        {
                            secondWord = typeArr[2];
                            indexOfSecond = GetIndexOfList(word, typeArr[2]);
                            getSecond = true;
                            break;
                        }
                    }

                    if (getFirst == true && getSecond == true)
                    {
                        word.RemoveAt(indexOfSecond);
                        word.Insert(indexOfSecond, firstWord);
                        word.RemoveAt(indexOfFrist);
                        word.Insert(indexOfFrist, secondWord);
                    }
                }
                else if (typeArr[0] == "Sort")
                {
                    word.Sort();
                }
                else if (typeArr[0] == "Replace")
                {
                    string firstWord = string.Empty;
                    int getIndex = 0;

                    if (word.Contains(typeArr[2]))
                    {
                        getIndex = GetIndexOfList(word, typeArr[2]);
                        word.RemoveAt(getIndex);
                        word.Insert(getIndex, typeArr[1]);
                    }
                }
                else if (typeArr[0] == "Put")
                {
                    //   string[] before = savedDelete.Split();

                    if (int.Parse(typeArr[2]) >= 1)
                    {

                        word.Insert(int.Parse(typeArr[2]) - 1, typeArr[1]);
                    }
                    else if (int.Parse(typeArr[2]) == 0)
                    {
                        word.Insert(int.Parse(typeArr[2]), typeArr[1]);
                    }

                }

                typeArr = Console.ReadLine()
                    .Split()
                   .ToArray();
            }

            Console.WriteLine(string.Join(' ', word));
        }


        private static int GetIndexOfList(List<string> word, string a)
        {
            int indexCount = 0;

            foreach (var w in word)
            {
                indexCount++;
                if (a == w)
                {
                    return indexCount - 1;
                }
            }

            return indexCount - 1;

        }
    }
}
