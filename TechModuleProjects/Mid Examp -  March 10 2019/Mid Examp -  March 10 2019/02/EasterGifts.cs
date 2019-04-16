using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class EasterGifts
    {
        static void Main(string[] args)
        {

            /* 
                Sweets Cozonac Clothes Flowers Wine Clothes Eggs Clothes
                Required Paper 8
                OutOfStock Clothes
                Required Chocolate 2
                JustInCase Hat
                OutOfStock Cable
                No Money
            */

            List<string> items = new List<string>();

            string[] arr = Console.ReadLine()
                 .Split()
                 .ToArray();
            FillList(arr, items);

            while (arr[0] != "No")
            {
                if (arr[0] == "OutOfStock")
                {
                    GetOutOfStock(arr, items);
                }
                else if (arr[0] == "Required")
                {
                    GetRequiredItem(arr, items);
                }
                else if (arr[0] == "JustInCase")
                {
                    GetJustInCaseGift(arr, items);
                }


                arr = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            Console.WriteLine(string.Join(' ', items));
        }

        private static void FillList(string[] arr, List<string> items)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                items.Add(arr[i]);
            }
        }

        private static void GetJustInCaseGift(string[] arr, List<string> items)
        {
            int lastIndex = items.Count - 1;
            items.RemoveAt(lastIndex);
            items.Insert(lastIndex, arr[1]);
        }

        private static void GetRequiredItem(string[] arr, List<string> items)
        {
            bool missing = false;
            var i = 0;
            for (i = 0; i < items.Count; i++)
            {
                if (items[i] == arr[1])
                {
                    items.RemoveAt(i);
                    items.Insert(i, arr[1]);
                    missing = true;
                }
            }

            if (missing == false)
            {
                int index = int.Parse(arr[2]);
                items.RemoveAt(index);
                items.Insert(index, arr[1]);
            }

        }

        public static void GetOutOfStock(string[] arr, List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (arr[1] == items[i])
                {
                    items.RemoveAt(i);
                }
            }
        }
    }
}


