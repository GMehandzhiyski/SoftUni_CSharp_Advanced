using System.Reflection.Metadata;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            string[,] matrix = new string[matrixSize, matrixSize];
            string[] inputSymbols = new string[matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                string inputSymbol = Console.ReadLine();

                int counterForEach = 0;
                foreach (var curSymbol in inputSymbol)
                {
                    inputSymbols[counterForEach] = curSymbol.ToString();
                    counterForEach++;

                }

                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = inputSymbols[col];
                }
            }

            string searchSymbol = (Console.ReadLine());

            string currSymbol = string.Empty;
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    currSymbol = matrix[row, col];
                    if (currSymbol == searchSymbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{searchSymbol} does not occur in the matrix");
        }
    }
}