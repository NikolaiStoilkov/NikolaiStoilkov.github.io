using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Text;
using System.Collections.Generic;

namespace P02.Line_Numbers
{
    /// <summary>
    /// I DONT KNOW HOW,BUT ITS WORKING!
    /// </summary>
    class StartUp
    {
        private static int _cnt = 0;
        static void Main(string[] args)
        {
            var text = File.ReadAllLines("../../../Input.txt");

            AddLineNumber(text);
        }

        private static void AddLineNumber(IEnumerable<string> fileLines)
        {
            string[] textLine = fileLines.ToArray();
            int cnt = fileLines.Count();
            int cntOfLines = 0;
            List<string> newText = new List<string>();

            for (int i = 0; i < cnt; i++)
            {
                // Count letters and punctuation marks.
                var newArr = CountOfLetters(textLine);

                var letters = newArr[0];
                var punctMarks = newArr[1];

                // Add every line from text file
                newText.Add($"Line {++cntOfLines}: {textLine[i]} ({letters})({punctMarks})");
                _cnt++;
            }

            Console.WriteLine(string.Join(Environment.NewLine, newText));
        }

        private static int[] CountOfLetters(string[] textLine)
        {
            var arr = new int[textLine.Length];

            int cntOfletters = 0;
            int cntOfPunctMarks = 0;



            for (int i = _cnt; i < textLine.Length; i++)
            {

                var line = textLine[i];

                for (int j = 0; j < line.Length; j++)
                {
                    var newLine = line[j];

                    // Skip WhiteSpace
                    if (newLine == ' ') continue;


                    //Checks if char is letter or not
                    if ((int)newLine >= 65 && (int)newLine <= 90
                     || (int)newLine >= 97 && (int)newLine <= 122)
                    {
                        cntOfletters++;
                    }
                    else
                    {
                        cntOfPunctMarks++;
                    }
                }
                break; // sorry
            }

            arr[0] = cntOfletters;
            arr[1] = cntOfPunctMarks;


            return arr;
        }
    }
}
