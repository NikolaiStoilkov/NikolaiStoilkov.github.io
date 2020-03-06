using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03.Word_Count
{
    class StartUp
    {
        private static void Main()
        {
            var textWords = new List<string>();

            using (var rdr = new StreamReader("text.txt")) //located in bin/debug
            {
                string input;
                while ((input = rdr.ReadLine()) != null)
                {
                    var wordPattern = @"\b[A-Za-z]+\b";
                    var rgx = new Regex(wordPattern);
                    MatchCollection matches = rgx.Matches(input);
                    textWords.AddRange(matches.Cast<Match>()
                        .Select(x => x.Value.ToLower())
                        .ToList());
                }
            }

            var occurences = new Dictionary<string, int>();
            using (var rdr = new StreamReader("words.txt")) //located in bin/debug
            {
                string input;
                while ((input = rdr.ReadLine()) != null)
                {
                    var count = textWords.Count(x => x == input);
                    occurences.Add(input, count);
                }
            }

            using (var wtr = new StreamWriter("result.txt")) // should be created in bin/debug
            {
                occurences.OrderByDescending(x => x.Value)
                    .ToList()
                    .ForEach(x => wtr.WriteLine("{0} - {1}", x.Key, x.Value));
            }
        }
    }
}