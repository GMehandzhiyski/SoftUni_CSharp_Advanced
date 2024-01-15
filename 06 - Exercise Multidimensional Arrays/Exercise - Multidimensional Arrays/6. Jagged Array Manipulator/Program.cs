namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowSize = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rowSize][];

            for (int row = 0; row < rowSize; row++)
            {
                int[] inputNumbers = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                    jagged[row] = inputNumbers; 
            }

            for (int row = 0; row < jagged.GetLength(0) - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length
                    && row <= jagged.GetLength(0) - 1)
                {
                  
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }
                if (jagged[row].Length != jagged[row + 1].Length
                    && row <= jagged.GetLength(0) - 1)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] /= 2;
                    }
                    for (int col = 0; col < jagged[row + 1].Length; col++)
                    {
                        jagged[row + 1][col] /= 2;
                    }

                }
            }

           
            string argumets = string.Empty;
            while ((argumets = Console.ReadLine()) != "End")
            {
               
                string[] commands = argumets
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (commands.Length != 4)
                {
                    continue;
                }

                string command = commands[0];
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);

                bool isCommandCorrect = CheckCommand(command);
                bool isCoordinateCorrect = CheckCoordinate(row, col, jagged);

                if (!isCommandCorrect
                    || !isCoordinateCorrect) 
                {
                    continue;
                }

                if (command == "Add")
                {
                    jagged[row][col] += value;

                }

                if (command == "Subtract")
                {
                    jagged[row][col] -= value; 
                }                
            }

            PrintJagged(jagged, rowSize);
        }

       
        private static bool CheckCoordinate(int row, int col, int[][] jagged)
        {
           return
                row >= 0 
                && row < jagged.Length
                && col >=0 
                && col < jagged[row].Length ;
        }

        private static bool CheckCommand(string command)
        {
            return command == "Add" || command == "Subtract";
        }

        private static void PrintJagged(int[][] jagged, int rowSize)
        {

            for (int row = 0; row < rowSize; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write($"{jagged[row][col]}" + " ");
                }
                Console.WriteLine();
            }
        
        } 
    }
}