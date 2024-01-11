using System.Runtime.CompilerServices;

namespace _5._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rowSize = matrixSize[0];
            int colSize = matrixSize[1];

            char[,] matrix = new char[rowSize,colSize];
            
            string inputWord = Console.ReadLine();
            string word = inputWord;
            int wordCounter = 0;
            for (int row = 0; row < rowSize; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col1 = 0; col1 < colSize; col1++)
                    {
                        if (wordCounter == word.Length)
                        {
                            wordCounter = 0;
                        }
                        matrix[row, col1] = word[wordCounter];
                        wordCounter++;
                    }
                }
                else
                {
                    for (int col2 = colSize - 1; col2 >= 0; col2--)
                    {
                        if (wordCounter == word.Length)
                        {
                            wordCounter = 0;
                        }

                        matrix[row, col2] = word[wordCounter];
                        wordCounter++;
                    }
                }
            }
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,]matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}