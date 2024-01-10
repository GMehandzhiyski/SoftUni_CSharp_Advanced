using System.Runtime.InteropServices;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] inputNumbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = inputNumbers[col];
                }
            }
            int rowsLength = matrix.GetLength(0) - 1;
            int colsLength = matrix.GetLength(1) - 1;
            int foundSquares = 0;
            for (int row = 0; row < rowsLength; row++)
            {
                for (int col = 0; col < colsLength; col++)
                {
                    string currSymbol = matrix[row, col];

                    if (currSymbol == matrix[row, col + 1]
                     && currSymbol == matrix[row + 1, col]
                     && currSymbol == matrix[row + 1, col + 1])
                    {
                        foundSquares++;
                    }

                }
            }

            Console.WriteLine(foundSquares);
        }
    }
}