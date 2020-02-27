using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> songs = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            Queue<string> songsInQue = new Queue<string>(songs);

            bool _flag = true;
            while (_flag)
            {

                if (songsInQue.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    return;
                }


                List<string> command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (command[0] == "Play")
                {
                    _flag = PlaySongs(songsInQue);

                    if (_flag == false)
                    {
                        Console.WriteLine("No more songs!");
                        return;
                    }

                }
                else if (command[0] == "Add")
                {
                    string songFromCommand = ConverFromCollectionToString(command);
                    AddSong(songsInQue, songFromCommand);
                }
                else if (command[0] == "Show")
                {
                    ShowSongs(songsInQue);
                }
            }


        }

        private static string ConverFromCollectionToString(List<string> command)
        {
            StringBuilder sb = new StringBuilder();
            command.Remove(command[0]);
            string emptySpace = " ";

            foreach (var word in command)
            {

                sb.Append(word + emptySpace);
            }

            return sb
                .ToString()
                .TrimEnd();
        }

        private static void ShowSongs(Queue<string> songsInQue)
        {
            Console.WriteLine(String.Join(", ", songsInQue));
        }

        private static void AddSong(Queue<string> songsInQue, string song)
        {
            if (songsInQue.Contains(song) == true)
            {
                Console.WriteLine($"{song} is already contained!");
                return;
            }

            songsInQue.Enqueue(song);
        }

        private static bool PlaySongs(Queue<string> songsInQue)
        {
            string song;
            try
            {
                song = songsInQue.Peek();
            }
            catch (Exception)
            {
                song = null;
            }


            if (songsInQue.Count > 0)
            {
                if (songsInQue.Contains(song))
                {

                    songsInQue.Dequeue();
                    return true;
                }
            }

            return false;
        }
    }
}
