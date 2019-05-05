using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class EasterShopping
    {
        static void Main(string[] args)
        {
            List<string> shops = new List<string>();

            string[] arr = Console.ReadLine()
                .Split()
                .ToArray();

            int countOfCommands = int.Parse(Console.ReadLine());

            FillList(arr, shops);

            for (int i = 0; i < countOfCommands; i++)
            {
                arr = Console.ReadLine()
              .Split()
              .ToArray();

                if (arr[0] == "Include")
                {
                    GetInclude(arr, shops);
                }
                else if (arr[0] == "Visit")
                {
                    GetVisitShop(arr, shops);
                }
                else if (arr[0] == "Prefer")
                {
                    GetPreferShop(arr, shops);
                }
                else if (arr[0] == "Place")
                {
                    GetPlaceShop(arr, shops);
                }


            }

            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(' ', shops));
        }

        private static void GetPlaceShop(string[] arr, List<string> shops)
        {
            if (int.Parse(arr[2]) >= shops.Count)
            {
                return;
            }
            else
            {
                int index = int.Parse(arr[2]) + 1;
                shops.Insert(index, arr[1]);
                //  shops[int.Parse(arr[2]) + 1] = arr[1];
            }
        }

        private static void GetPreferShop(string[] arr, List<string> shops)
        {
            string firstShop = string.Empty;
            string secondShop = string.Empty;

            if (int.Parse(arr[2]) >= shops.Count)
            {
                return;
            }

            firstShop = shops[int.Parse(arr[1])];

            secondShop = shops[int.Parse(arr[2])];


            shops[int.Parse(arr[2])] = firstShop;
            shops[int.Parse(arr[1])] = secondShop;


        }

        private static void GetVisitShop(string[] arr, List<string> shops)
        {
            if (arr[1] == "first")
            {
                if (int.Parse(arr[2]) >= shops.Count)
                {
                    return;
                }


                int index = int.Parse(arr[2]);
                for (int i = 0; i < index; i++)
                {
                    shops.RemoveAt(0);
                }
            }
            else if (arr[1] == "last")
            {
                if (int.Parse(arr[2]) == 1)
                {
                    int getLastIndex = shops.Count - 1;
                    shops.RemoveAt(getLastIndex);
                }
                else
                {
                    if (int.Parse(arr[2]) >= shops.Count)
                    {
                        return;
                    }
                    int rotation = shops.Count - int.Parse(arr[2]);
                    for (int i = shops.Count - 1; i >= rotation; i--)
                    {
                        shops.RemoveAt(i);
                    }
                }

            }
        }

        private static void GetInclude(string[] arr, List<string> shops)
        {
            shops.Add(arr[1]);
        }

        private static void FillList(string[] arr, List<string> shops)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                shops.Add(arr[i]);
            }
        }
    }
}
