using System.Runtime.InteropServices;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rowsSize = matrixSize[0];
            int colsSize = matrixSize[1];

            int[,] matrix = new int[rowsSize, colsSize];

            for (int row = 0; row < rowsSize; row++)
            {
                int[] inputNumber = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToArray();

                for (int col = 0; col < colsSize; col++)
                {
                    matrix[row, col] = inputNumber[col];
                }
            }
            int currSmalMatrixSum = 0;
            int smallMatrixSum = int.MinValue;
            int smalMatrixStartCoordinateRow = 0;
            int smalMatrixStartCoordinateCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (row + 2 > matrix.GetLength(0) - 1)
                {
                    break;
                }
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {

                    if (col + 2 > matrix.GetLength(1) - 1)
                    {
                        break;
                    }
                    int RowOne0  = matrix[row, col];
                    int RowOne1 = matrix[row, col + 1];
                    int RowOne2 = matrix[row, col + 2];

                    int RowTwo0 = matrix[row + 1, col];
                    int RowTwo1 = matrix[row + 1, col + 1];
                    int RowTwo2 = matrix[row + 1, col + 2];

                    int RowThree0 = matrix[row + 2, col];
                    int RowThree1 = matrix[row + 2, col + 1];
                    int RowThree2 = matrix[row + 2, col + 2];

                    currSmalMatrixSum = (RowOne0 + RowOne1 + RowOne2)
                                        + (RowTwo0 + RowTwo1 + RowTwo2)
                                        + (RowThree0 + RowThree1 + RowThree2);

                    if (currSmalMatrixSum > smallMatrixSum)
                    {
                        smallMatrixSum = currSmalMatrixSum;
                        smalMatrixStartCoordinateRow = row;
                        smalMatrixStartCoordinateCol = col;
                    }
                }

               
            }
            Console.WriteLine($"Sum = {smallMatrixSum}");
            PrintMatrix(matrix, smalMatrixStartCoordinateCol, smalMatrixStartCoordinateRow);
       
        }

        private static void PrintMatrix(int[,] matrix, int smalMatrixStartCoordinateCol, int smalMatrixStartCoordinateRow)
        {
            int currElement = 0;
            for (int row = smalMatrixStartCoordinateRow; row < 3 + smalMatrixStartCoordinateRow; row++)
            {
                for (int col = smalMatrixStartCoordinateCol; col < 3 + smalMatrixStartCoordinateCol; col++)
                {
                    currElement = matrix[row, col];
                    Console.Write(currElement + " ");
                }

                Console.WriteLine();
            }
        }
    }
}