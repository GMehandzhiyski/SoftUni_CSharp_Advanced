using System.Runtime.InteropServices;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int matrixSizeRows = matrixSize[0];
            int matrixSizeCols = matrixSize[1];

            int[,] matrix = new int[matrixSizeRows,matrixSizeCols];
            // add numbers to Matrix
            for (int row = 0; row < matrixSizeRows; row++)
            {
                int[] inputString = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrixSizeCols; col++)
                {
                    matrix[row, col] = inputString[col];
                }
            }
            

            int sumOfSmalMatrix = 0;
            int one = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            string smalMatrixRow = string.Empty;
            string smalMatrixCol = string.Empty;
            for (int row = matrixSizeRows - 1; row >= 0 ; row--)
            {
                for (int col = matrixSizeCols - 1; col >= 0; col--)
                {
                    
                    if (col != 0
                        && row != 0) 
                    {
                        one = matrix[row, col];
                        two = matrix[row, col - 1];
                        three = matrix[row - 1, col];
                        four = matrix[row - 1, col - 1];

                        int currSumOfSmalMatrix = (one + two) + (three + four);

                        if (currSumOfSmalMatrix >= sumOfSmalMatrix)
                        {
                            sumOfSmalMatrix = currSumOfSmalMatrix;
                            smalMatrixRow = two + " " + one;
                            smalMatrixCol = four + " " + three;
                        }
                    }
                    
                  
                }
            }
            Console.WriteLine(smalMatrixCol);
            Console.WriteLine(smalMatrixRow);
            Console.WriteLine(sumOfSmalMatrix);
        }
    }
}