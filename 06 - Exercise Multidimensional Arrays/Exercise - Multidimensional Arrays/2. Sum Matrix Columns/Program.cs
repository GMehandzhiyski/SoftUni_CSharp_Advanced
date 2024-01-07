namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize  = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];

            int[,] matrix = new int[rows, cols];

            // add value to matrix
            for (int row = 0; row < rows; row++)
            {
                int[] inputRows = Console.ReadLine()
                    .Split(" " , StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col <cols; col++)
                {
                    matrix[row, col] = inputRows[col];
                }

            }
            //print matrix answer

            for (int col = 0; col < cols; col++)
            {
                int sumOfRow = 0;
                for (int row = 0; row < rows; row++)
                {
                   int currValue = matrix[row, col];
                    sumOfRow += currValue;
                }
                Console.WriteLine(sumOfRow);
            }
        }
    }
}