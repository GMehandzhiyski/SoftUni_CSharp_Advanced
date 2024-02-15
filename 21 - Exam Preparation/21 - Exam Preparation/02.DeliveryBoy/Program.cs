using System.Runtime.CompilerServices;
using System.Text;

namespace _02.DeliveryBoy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fieldSize = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rowSize = fieldSize[0];
            int colSize = fieldSize[1];

            char[,] field = new char[rowSize,colSize];
            int firstPlayerRow = 0;
            int firstPlayerCol = 0;
            int playerRow = 0;
            int playerCol = 0;  
            for (int row = 0; row < field.GetLength(0); row++)
            {
                string inputElements = Console.ReadLine();
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = inputElements[col];

                    if (field[row, col] == 'B')
                    {
                        firstPlayerRow = row;
                        firstPlayerCol = col;
                    }
                }
            }
            playerRow = firstPlayerRow;
            playerCol = firstPlayerCol;
            int currRow = 0;
            int currCol = 0;
            int nextRow = 0;
            int nextCol = 0;
            bool hetakePizza = false;

            while (true)
            {
                string token = Console.ReadLine();

                if (token == "up")
                { 
                
                }
                else if (token == "down")
                {
                    currCol = playerCol;
                    currRow = playerRow;
                    nextRow = currRow + 1 ;
                    nextCol = currRow;

                    bool isCoordinateIsValid = CheckCoordinate(field, nextRow, nextCol);
                    if (!isCoordinateIsValid) 
                    {
                        Console.WriteLine("The delivery is late. Order is canceled.");
                        field[playerRow, playerCol] = ' ';
                        PrintField(field);
                    }

                    if (field[nextRow, nextCol] == 'P')
                    {
                        field[nextRow, nextCol] = 'R';
                        hetakePizza = true;

                    }
                    else if (field[nextRow, nextCol] == 'A'
                             && hetakePizza)
                    {
                        field[nextRow, nextCol] = 'P';
                        field[firstPlayerRow, firstPlayerCol] = 'B';
                    }
                    else if (field[nextRow, nextCol] == '-')
                    {
                        field[nextRow, nextCol] = '.';
                    }
                    else
                    {
                        continue;
                    }

                }
                else if (token == "right")
                {

                }
                else if (token == "left")
                {

                }


            }
        }

        private static void PrintField(char[,] field)
        {
            StringBuilder   sb = new StringBuilder();   
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    sb.Append(field[row, col]);
                }
                Console.WriteLine(sb);
            }
        }

        private static bool CheckCoordinate(char[,] field, int nextRow, int nextCol)
        {
            return nextRow >= 0 && nextRow < field.GetLength(0)
                   && nextCol >= 0 && nextCol < field.GetLength(1);
        }
    }
}