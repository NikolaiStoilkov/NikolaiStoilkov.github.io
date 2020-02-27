namespace SquareMatrix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;


    class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            // fill matrix - input
            string[,] matrix = FillMatrix();

            // proccess - finding squares
            var quares = SearchAboutSquares(matrix);

            //output - print count of squares
            PrintCountOfFoundSquares(quares);
        }

        private static void PrintCountOfFoundSquares(int squares)
        {
            Console.WriteLine(squares);
        }

        private static int SearchAboutSquares(string[,] matrix)
        {
            int cnt = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] &&    // Trying to find
                        matrix[row, col] == matrix[row + 1, col] &&     // squares of chars
                        matrix[row, col] == matrix[row + 1, col + 1])     // in matrix.
                    {
                        cnt++;
                    }
                }
            }

            return cnt;
        }

        public static string[,] FillMatrix()
        {
            int[] sizeOf = Console.ReadLine() // size of matrix
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            var matrix = new string[sizeOf[0], sizeOf[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine() // input for matix 
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            return matrix;
        }

    }
}