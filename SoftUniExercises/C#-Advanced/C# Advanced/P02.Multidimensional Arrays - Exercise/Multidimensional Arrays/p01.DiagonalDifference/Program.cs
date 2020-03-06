using System;
using System.Linq;


namespace Matrix_Exe
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();


                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int diagonalSum = 0;
            int diagonalSecond = 0;
            for (int row = 0; row < size; row++)
            {
                diagonalSum += matrix[row, row];
                diagonalSecond += matrix[row, size - row - 1];
            }

            Console.WriteLine(Math.Abs(diagonalSecond - diagonalSum));
        }
    }
}
