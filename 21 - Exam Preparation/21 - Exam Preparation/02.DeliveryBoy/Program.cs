using System.Runtime.CompilerServices;
using System.Text;
/*
5 6
B----A
*-***-
*-***-
*----P
******
right
down
down
down
right
right
right
right
up
up
up


*/
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
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
            
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
                    currCol = playerCol;
                    currRow = playerRow;
                    nextRow = currRow - 1;
                    nextCol = currCol;

                    bool isCoordinateIsValid = CheckCoordinate(field, nextRow, nextCol);
                    if (!isCoordinateIsValid)
                    {
                        if (field[currRow, currCol] == '-'
                              || field[currRow, currCol] == 'B')
                        {
                            field[currRow, currCol] = '.';
                        }
                        Console.WriteLine("The delivery is late. Order is canceled.");
                        field[firstPlayerRow, firstPlayerCol] =' ';
                        PrintField(field);
                        return;
                    }

                    if (field[nextRow, nextCol] == '-')
                    {
                        if (field[currRow, currCol] == '-'
                            || field[currRow, currCol] == 'B')
                        {
                            field[currRow, currCol] = '.';
                        }
                    }
                    else if (field[nextRow, nextCol] == 'P')
                    {
                        if (field[currRow, currCol] == '-'
                            || field[currRow, currCol] == 'B')
                        {
                            field[currRow, currCol] = '.';
                        }
                        field[nextRow, nextCol] = 'R';
                        hetakePizza = true;
                        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");

                    }
                    else if (field[nextRow, nextCol] == 'A'
                             && hetakePizza)
                    {
                        if (field[currRow, currCol] == '-'
                            || field[currRow, currCol] == 'B')
                        {
                            field[currRow, currCol] = '.';
                        }
                        field[nextRow, nextCol] = 'P';
                        field[firstPlayerRow, firstPlayerCol] = 'B';
                        Console.WriteLine("Pizza is delivered on time! Next order...");
                        PrintField(field);
                        return;
                    }
                    else if (field[nextRow, nextCol] == 'A'
                             && !hetakePizza)
                    {
                        if (field[currRow, currCol] == '-'
                                 || field[currRow, currCol] == 'B')
                        {
                            field[currRow, currCol] = '.';
                        }

                    }
                    else if (field[nextRow, nextCol] == '*')
                    {
                        playerRow = currRow;
                        playerCol = currCol;
                        continue;
                    }

                    playerRow = nextRow;
                    playerCol = nextCol;
                    //PrintField(field);
                }
                else if (token == "down")
                {
                    currCol = playerCol;
                    currRow = playerRow;
                    nextRow = currRow + 1 ;
                    nextCol = currCol;

                    bool isCoordinateIsValid = CheckCoordinate(field, nextRow, nextCol);
                    if (!isCoordinateIsValid) 
                    {
                        if (field[currRow, currCol] == '-'
                              || field[currRow, currCol] == 'B')
                        {
                            field[currRow, currCol] = '.';
                        }
                        Console.WriteLine("The delivery is late. Order is canceled.");
                        field[firstPlayerRow, firstPlayerCol] = ' ';
                        PrintField(field);
                        return;
                    }

                    if (field[nextRow, nextCol] == '-')
                    {
                        if (field[currRow, currCol] == '-'
                              || field[currRow, currCol] == 'B')
                        {
                            field[currRow, currCol] = '.';
                        }
                    }
                    else if (field[nextRow, nextCol] == 'P')
                    {
                        if (field[currRow, currCol] == '-'
                             || field[currRow, currCol] == 'B')
                        {
                            field[currRow, currCol] = '.';
                        }
                        field[nextRow, nextCol] = 'R';
                        hetakePizza = true;
                        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");

                    }
                    else if (field[nextRow, nextCol] == 'A'
                             && hetakePizza)
                    {
                        if (field[currRow, currCol] == '-'
                            || field[currRow, currCol] == 'B')
                        {
                            field[currRow, currCol] = '.';
                        }
                        field[nextRow, nextCol] = 'P';
                        field[firstPlayerRow, firstPlayerCol] = 'B';
                        Console.WriteLine("Pizza is delivered on time! Next order...");
                        PrintField(field);
                        return;
                    }
                    else if (field[nextRow, nextCol] == 'A'
                             && !hetakePizza)
                    {
                        if (field[currRow, currCol] == '-'
                                 || field[currRow, currCol] == 'B')
                        {
                            field[currRow, currCol] = '.';
                        }

                    }
                    else if(field[nextRow, nextCol] == '*')
                    {
                        playerRow = currRow;
                        playerCol = currCol;
                        continue;
                    }

                    playerRow = nextRow;
                    playerCol = nextCol;
                    //PrintField (field);

                }
                else if (token == "right")
                {
                    currCol = playerCol;
                    currRow = playerRow;
                    nextRow = currRow;
                    nextCol = currCol + 1; 

                    bool isCoordinateIsValid = CheckCoordinate(field, nextRow, nextCol);
                    if (!isCoordinateIsValid)
                    {
                        if (field[currRow, currCol] == '-'
                              || field[currRow, currCol] == 'B')
                        {
                            field[currRow, currCol] = '.';
                        }
                        Console.WriteLine("The delivery is late. Order is canceled.");
                        field[firstPlayerRow, firstPlayerCol] = ' ';
                        PrintField(field);
                        return;
                    }

                    if (field[nextRow, nextCol] == '-')
                    {
                        if (field[currRow, currCol] == '-'
                            || field[currRow, currCol] == 'B')
                        {
                            field[currRow, currCol] = '.';
                        }

                    }
                    else if (field[nextRow, nextCol] == 'P')
                    {
                        if (field[currRow, currCol] == '-'
                             || field[currRow, currCol] == 'B')
                        {
                            field[currRow, currCol] = '.';
                        }
                        field[nextRow, nextCol] = 'R';
                        hetakePizza = true;
                        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");

                    }
                    else if (field[nextRow, nextCol] == 'A'
                             && hetakePizza)
                    {
                        if (field[currRow, currCol] == '-'
                            || field[currRow, currCol] == 'B')
                        {
                            field[currRow, currCol] = '.';
                        }
                        field[nextRow, nextCol] = 'P';
                        field[firstPlayerRow, firstPlayerCol] = 'B';
                        Console.WriteLine("Pizza is delivered on time! Next order...");
                        PrintField(field);
                        return;
                    }
                    else if (field[nextRow, nextCol] == 'A'
                             && !hetakePizza)
                    {
                        if (field[currRow, currCol] == '-'
                                 || field[currRow, currCol] == 'B')
                        {
                            field[currRow, currCol] = '.';
                        }

                    }
                    else if (field[nextRow, nextCol] == '*')
                    {
                        playerRow = currRow;
                        playerCol = currCol;
                        continue;
                    }

                    playerRow = nextRow;
                    playerCol = nextCol;
                    //PrintField(field);
                }
                else if (token == "left")
                {
                    currCol = playerCol;
                    currRow = playerRow;
                    nextRow = currRow;
                    nextCol = currCol - 1;

                    bool isCoordinateIsValid = CheckCoordinate(field, nextRow, nextCol);
                    if (!isCoordinateIsValid)
                    {
                        if (field[currRow, currCol] == '-'
                              || field[currRow, currCol] == 'B')
                        {
                            field[currRow, currCol] = '.';
                        }
                        Console.WriteLine("The delivery is late. Order is canceled.");
                        field[firstPlayerRow, firstPlayerCol] = ' ';
                        PrintField(field);
                        return;
                    }

                    if (field[nextRow, nextCol] == '-')
                    {
                        if (field[currRow, currCol] == '-'
                             || field[currRow, currCol] == 'B')
                        {
                            field[currRow, currCol] = '.';
                        }

                    }
                    else if (field[nextRow, nextCol] == 'P')
                    {
                        if (field[currRow, currCol] == '-'
                            || field[currRow, currCol] == 'B')
                        {
                            field[currRow, currCol] = '.';
                        }
                        field[nextRow, nextCol] = 'R';
                        hetakePizza = true;
                        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");

                    }
                    else if (field[nextRow, nextCol] == 'A'
                             && hetakePizza)
                    {
                        if (field[currRow, currCol] == '-'
                             || field[currRow, currCol] == 'B')
                        {
                            field[currRow, currCol] = '.';
                        }
                        field[nextRow, nextCol] = 'P';
                        field[firstPlayerRow, firstPlayerCol] = 'B';
                        Console.WriteLine("Pizza is delivered on time! Next order...");
                        PrintField(field);
                        return;
                    }
                    else if (field[nextRow, nextCol] == 'A'
                             && !hetakePizza)
                    {
                        if (field[currRow, currCol] == '-'
                                 || field[currRow, currCol] == 'B')
                        {
                            field[currRow, currCol] = '.';
                        }

                    }
                    else if (field[nextRow, nextCol] == '*')
                    {
                        playerRow = currRow;
                        playerCol = currCol;
                        //PrintField(field);
                        continue;

                    }
                   

                    playerRow = nextRow;
                    playerCol = nextCol;
                    //PrintField(field);
                }


            }
        }

        private static void PrintField(char[,] field)
        {
               
            for (int row = 0; row < field.GetLength(0); row++)
            {
                StringBuilder sb = new StringBuilder();
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