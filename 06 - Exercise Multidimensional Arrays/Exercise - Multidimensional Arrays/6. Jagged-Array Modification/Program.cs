using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixColsNumber = int.Parse(Console.ReadLine());

            int[][] matrix = new int[matrixColsNumber][];
            matrix [0] = new int[matrixColsNumber];

            for (int row = 0; row < matrixColsNumber; row++)
            {
                int[] inputRows = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

               matrix[row] = inputRows;
            }

            string argumnets = string.Empty;
            while ((argumnets = Console.ReadLine()) != "END")
            {
                string[] commands = argumnets
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commands[0];
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);

                bool isCoordinatesIsValid = ChekedValidCoordinates(row, col, matrix);
                if (!isCoordinatesIsValid) 
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (command == "Add")
                {
                    matrix[row][col] += value;
                }
                else if (command == "Subtract")
                {
                    matrix[row][col] -= value;
                }
                else
                {
                    continue;
                }
            
            
            }

            printMatrix(matrix);
            
            
        }

        private static void printMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                Console.WriteLine();
            }

        }

        private static bool ChekedValidCoordinates(int row, int col, int[][] matrix)
        {
            if (row <= matrix.Length - 1 && row >= 0
                && col <= matrix.Length - 1 && col >= 0) 
            {
              return true;
            }

            return false;
        }
    }
}