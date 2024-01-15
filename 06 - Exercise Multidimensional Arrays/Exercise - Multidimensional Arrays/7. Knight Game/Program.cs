using System.Data;

namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const char constChar = 'K';
            int highValueKnight = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            int counterKnight = 0;
            int deadKnight = 0;

            int matrixSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize,matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                string inputSymbol = Console.ReadLine();

                for (int col = 0; col <matrixSize; col++)
                {
                    matrix[row, col] = inputSymbol[col];
                }
            }


            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0;col < matrixSize; col++)
                {
                    if (matrix[row, col] != constChar)
                    {
                        continue;
                    }

                    int counterKnightMet = searchKinght(row, col, matrixSize, counterKnight, constChar, matrix);

                    if (highValueKnight < counterKnightMet)
                    {
                        highValueKnight = counterKnightMet;
                        bestRow = row;
                        bestCol = col;

                        if(counterKnightMet == 8)
                        {
                            matrix[bestCol, bestCol] = '0';
                            deadKnight++;
                        }

                    }

                    counterKnight = 0;
                }
            }
            //Console.WriteLine(bestRow);
            //Console.WriteLine(bestCol);
            Console.WriteLine(deadKnight);
        }

        private static bool isCoordinateCorrect(int v1, int v2,int matrixSize)
        {
            return
               v1 >= 0
               && v1 <= matrixSize - 1
               && v2 >= 0
               && v2 <= matrixSize - 1;
               
        }

        private static int searchKinght(int row, int col, int matrixSize, int counterKnight, char constChar, char[,]matrix)
        {
            
            if (isCoordinateCorrect((row + 1), (col + 2), matrixSize)
                && matrix[row + 1, col + 2] == constChar)// |__
            {
                counterKnight++;

            }
            if (isCoordinateCorrect((row + 1), (col - 2), matrixSize)
               && matrix[row + 1, col - 2] == constChar)// __|
            {
                counterKnight++;
            }

            if (isCoordinateCorrect(row - 1, col + 2, matrixSize)
                && matrix[row - 1, col + 2] == constChar)// |^^
            {
                counterKnight++;
            }

            if (isCoordinateCorrect(row - 1, col - 2, matrixSize)
                && matrix[row - 1, col - 2] == constChar)// ^^|
            {
                counterKnight++;
            }

            if (isCoordinateCorrect(row - 2, col + 1, matrixSize)
                && matrix[row - 2, col + 1] == constChar)// |^
            {
                counterKnight++;
            }
            if (isCoordinateCorrect(row - 2, col - 1, matrixSize)
               && matrix[row - 2, col - 1] == constChar)// ^|
            {
                counterKnight++;
            }

            if (isCoordinateCorrect(row + 2, col + 1, matrixSize)
                && matrix[row + 2, col + 1] == constChar)// |_
            {
                counterKnight++;
            }
            if (isCoordinateCorrect(row + 2, col - 1, matrixSize)
                && matrix[row + 2, col - 1] == constChar)// _|
            {
                counterKnight++;
            }
            return counterKnight;
        }
    }
}