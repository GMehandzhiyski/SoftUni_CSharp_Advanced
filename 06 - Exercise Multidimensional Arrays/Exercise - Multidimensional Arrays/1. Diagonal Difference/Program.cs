using System.Reflection.Metadata;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                int[] inputNumbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = inputNumbers[col];
                }

            }

            int primaryDiagSum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                primaryDiagSum += matrix[i, i];
            }

            int secondDiagSum = 0;
            int colDiag = 0;
            for (int row = matrix.GetLength(1) - 1; row >= 0; row--)
            {

                secondDiagSum += matrix[row, colDiag];
                colDiag++;
               

            }

            Console.WriteLine(Math.Abs(primaryDiagSum - secondDiagSum));
         
        }
    }
}