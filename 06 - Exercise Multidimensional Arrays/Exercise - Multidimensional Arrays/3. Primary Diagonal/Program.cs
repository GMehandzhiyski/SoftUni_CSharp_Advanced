namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                int[] inputNumber = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = inputNumber[col];
                }

            }
            int sumOfDianonals = 0;
            for (int row  = 0; row < matrixSize; row++)
            {
               sumOfDianonals += matrix[row, row];
            }

            Console.WriteLine(sumOfDianonals);
        }
    }
}