using System.Text;

namespace _02.MouseInTheKitchen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fieldSize = Console.ReadLine()
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int rowSize = fieldSize[0];
            int colSize = fieldSize[1];

            char[,] field = new char[rowSize, colSize];
            //int firstPlayerRow = 0;
            //int firstPlayerCol = 0;
            int playerRow = 0;
            int playerCol = 0;
            int cheeseCounter = 0; 
            for (int row = 0; row < field.GetLength(0); row++)
            {
                string inputElements = Console.ReadLine();
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = inputElements[col];

                    if (field[row, col] == 'M')
                    {
                        //firstPlayerRow = row;
                        //firstPlayerCol = col;
                        playerRow = row;
                        playerCol = col;
                    }
                    if (field[row, col] == 'C')
                    {
                        cheeseCounter++;    
                    }
                }
            }
            int currRow = 0;
            int currCol = 0;
            int nextRow = 0;
            int nextCol = 0;

            string token = string.Empty;
            while ((token = Console.ReadLine()) != "danger")
            {
                if (token == "up")
                {
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow - 1;
                    nextCol = currCol;
                    bool isCoordinateIsValid = CheckValidCoordinate(field, nextRow,nextCol);
                    if (!isCoordinateIsValid)
                    {
                        Console.WriteLine("No more cheese for tonight!");
                        PrintField(field);
                        return;
                    }


                    if (field[nextRow,nextCol] == 'C')
                    {
                        cheeseCounter--;

                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 'M';
                        playerRow = nextRow;
                        playerCol = nextCol;

                        if (cheeseCounter == 0 )
                        {
                            Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                            PrintField(field);
                            return;
                        }
                    }
                    else if (field[nextRow, nextCol] == 'T')
                    {
                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 'M';
                        Console.WriteLine("Mouse is trapped!");
                        PrintField(field);
                        return;
                    }
                    else if (field[nextRow, nextCol] == '@')
                    {
                        playerRow = currRow;
                        playerCol = currCol;
                    }
                    else if (field[nextRow, nextCol] == '*')
                    {
                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 'M';
                        playerRow = nextRow;
                        playerCol = nextCol;
                    }
                    
                   // PrintField(field);
                }
                else if (token == "down")
                {
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow + 1;
                    nextCol = currCol;
                    bool isCoordinateIsValid = CheckValidCoordinate(field, nextRow, nextCol);
                    if (!isCoordinateIsValid)
                    {
                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 'M';
                        Console.WriteLine("No more cheese for tonight!");
                        PrintField(field);
                        return;
                    }


                    if (field[nextRow, nextCol] == 'C')
                    {
                        cheeseCounter--;

                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 'M';
                        playerRow = nextRow;
                        playerCol = nextCol;

                        if (cheeseCounter == 0)
                        {
                            Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                            PrintField(field);
                            return;
                        }
                    }
                    else if (field[nextRow, nextCol] == 'T')
                    {
                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 'M';
                        Console.WriteLine("Mouse is trapped!");
                        PrintField(field);
                        return;
                    }
                    else if (field[nextRow, nextCol] == '@')
                    {
                        playerRow = currRow;
                        playerCol = currCol;
                    }
                    else if (field[nextRow, nextCol] == '*')
                    {
                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 'M';
                        playerRow = nextRow;
                        playerCol = nextCol;
                    }

                    //PrintField(field);
                }
                else if (token == "left")
                {
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow;
                    nextCol = currCol - 1;
                    bool isCoordinateIsValid = CheckValidCoordinate(field, nextRow, nextCol);
                    if (!isCoordinateIsValid)
                    {
                        Console.WriteLine("No more cheese for tonight!");
                        PrintField(field);
                        return;
                    }


                    if (field[nextRow, nextCol] == 'C')
                    {
                        cheeseCounter--;

                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 'M';
                        playerRow = nextRow;
                        playerCol = nextCol;

                        if (cheeseCounter == 0)
                        {
                            Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                            PrintField(field);
                            return;
                        }
                    }
                    else if (field[nextRow, nextCol] == 'T')
                    {
                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 'M';
                        Console.WriteLine("Mouse is trapped!");
                        PrintField(field);
                        return;
                    }
                    else if (field[nextRow, nextCol] == '@')
                    {
                        playerRow = currRow;
                        playerCol = currCol;
                        PrintField(field);
                    }
                    else if (field[nextRow, nextCol] == '*')
                    {
                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 'M';
                        playerRow = nextRow;
                        playerCol = nextCol;
                    }

                   //PrintField(field);
                }
                else if (token == "right")
                {
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow;
                    nextCol = currCol + 1;
                    bool isCoordinateIsValid = CheckValidCoordinate(field, nextRow, nextCol);
                    if (!isCoordinateIsValid)
                    {
                        Console.WriteLine("No more cheese for tonight!");
                        PrintField(field);
                        return;
                    }


                    if (field[nextRow, nextCol] == 'C')
                    {
                        cheeseCounter--;

                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 'M';
                        playerRow = nextRow;
                        playerCol = nextCol;

                        if (cheeseCounter == 0)
                        {
                            Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                            PrintField(field);
                            return;
                        }
                    }
                    else if (field[nextRow, nextCol] == 'T')
                    {
                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 'M';
                        Console.WriteLine("Mouse is trapped!");
                        PrintField(field);
                        return;
                    }
                    else if (field[nextRow, nextCol] == '@')
                    {
                        playerRow = currRow;
                        playerCol = currCol;
                      
                    }
                    else if (field[nextRow, nextCol] == '*')
                    {
                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 'M';
                        playerRow = nextRow;
                        playerCol = nextCol;
                    }

                    //PrintField(field);
                }

            }
            Console.WriteLine("Mouse will come back later!");
            PrintField(field);
        }

        private static void PrintField(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                StringBuilder   sb = new StringBuilder();    
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    sb.Append(field[row,col]);
                }
                Console.WriteLine(sb.ToString());
            }
        }

        private static bool CheckValidCoordinate(char[,] field, int nextRow, int nextCol)
        {
            return nextRow >= 0 && nextRow < field.GetLength(0)
                && nextCol >= 0 && nextCol < field.GetLength(1);
        }
    }
}