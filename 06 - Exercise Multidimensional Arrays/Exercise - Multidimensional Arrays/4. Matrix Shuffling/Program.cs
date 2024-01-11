namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (matrixSize[0] <= 0
               || matrixSize[0] <= 0
               || matrixSize.Length <= 1)
            {
                return;
            }

            int rowsSize = matrixSize[0];
            int colsSize = matrixSize[1];

            string[,] matrix = new string[rowsSize, colsSize];

            for (int row = 0; row < rowsSize; row++)
            {
                string[] inputNumber = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                
                if (inputNumber.Length == colsSize)
                {
                    for (int col = 0; col < colsSize; col++)
                    {
                        matrix[row, col] = inputNumber[col];
                    }
                }
                else
                {
                    continue;
                }

                
            }

            string argumets = string.Empty;
            while ((argumets = Console.ReadLine()) != "END")
            {
                string[]commands = argumets
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray(); 

                string command = commands[0];
                bool isCommandCorect = CheckCommand(command);

                if (!isCommandCorect
                    && command.Length != 5)
                {
                    PrintErrorMesage();
                    continue;
                }

                int rowFirst = int.Parse(commands[1]);
                int colFirst = int.Parse(commands[2]);
                int rowSecond = int.Parse(commands[3]);
                int colSecond = int.Parse(commands[4]);

                
                bool isCoordinateCorect = CheckCoordinate(matrix, rowFirst, colFirst, rowSecond, colSecond);

                if (isCoordinateCorect)
                { 
                    string currTempValue = string.Empty;
                    currTempValue = matrix[rowFirst,colFirst];
                    matrix[rowFirst, colFirst] = matrix[rowSecond, colSecond];
                    matrix[rowSecond, colSecond] = currTempValue;
                    PrintMatrix(matrix);
                }
                else
                {
                    PrintErrorMesage();
                }

            }
        }

        private static void PrintErrorMesage()
        {
            Console.WriteLine("Invalid input!");
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            
        }

        private static bool CheckCoordinate(string[,] matrix, int rowFirst, int colFirst, int rowSecond, int colSecond)
        {
            if (rowFirst >= 0 && rowFirst <= matrix.GetLength(0) - 1
               && colFirst >= 0 && colFirst <= matrix.GetLength(1) - 1
               && rowSecond >= 0 && rowSecond <= matrix.GetLength(0) - 1
               && colSecond >= 0 && rowSecond <= matrix.GetLength(1) - 1)
            { 
                return true;
            }
                return false;
        }

        private static bool CheckCommand(string command)
        {
            return command == "swap";
        }
    }
}