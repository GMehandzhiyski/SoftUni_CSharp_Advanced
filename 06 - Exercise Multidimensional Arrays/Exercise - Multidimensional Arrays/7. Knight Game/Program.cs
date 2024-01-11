namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            ;
        }
    }
}