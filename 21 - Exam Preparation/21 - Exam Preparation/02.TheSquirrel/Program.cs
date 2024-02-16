using System.Text;

namespace _02.TheSquirrel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            string[] command = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Queue<string> comands = new Queue<string>(command);

            char[,] field = new char[fieldSize, fieldSize];
            //int firstPlayerRow = 0;
            //int firstPlayerCol = 0;
            int playerRow = 0;
            int playerCol = 0;
            int hazelnuts = 0;

            for (int row = 0; row < field.GetLength(0); row++)
            {
                string inputElements = Console.ReadLine();

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = inputElements[col];

                    if (field[row, col] == 's')
                    {
                        //firstPlayerRow = row;
                        //firstPlayerCol = col;
                        playerRow = row;
                        playerCol = col;
                    }
                  
                }
            }
            int currRow = 0;
            int currCol = 0;
            int nextRow= 0;
            int nextCol = 0;    

            while (comands.Any())
            {
                string currComand = comands.Dequeue();

                if (currComand == "up")
                {
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow - 1;
                    nextCol = currCol;

                    bool isCorrdinateCorect = CkeckCoordinate(field, nextRow, nextCol);
                    if (!isCorrdinateCorect) 
                    {
                        Console.WriteLine("The squirrel is out of the field.");
                        Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
                        return;
                    }


                    if (field[nextRow,nextCol] == 'h')
                    {
                        hazelnuts++;
                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 's';
                        if (hazelnuts == 3)
                        {
                            Console.WriteLine("Good job! You have collected all hazelnuts!");
                            Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
                            return;
                        }
                    }
                    else if(field[nextRow, nextCol] == '*')
                    {
                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 's';
                    }
                    else if (field[nextRow, nextCol] == 't')
                    {
                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 's';
                        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                        Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
                        return;
                    }

                    playerRow = nextRow;
                    playerCol = nextCol;

                    //PrintField(field);

                }
                else if (currComand == "down")
                {
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow + 1;
                    nextCol = currCol;

                    bool isCorrdinateCorect = CkeckCoordinate(field, nextRow, nextCol);
                    if (!isCorrdinateCorect)
                    {
                        Console.WriteLine("The squirrel is out of the field.");
                        Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
                        return;
                    }


                    if (field[nextRow, nextCol] == 'h')
                    {
                        hazelnuts++;
                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 's';
                        if (hazelnuts == 3)
                        {
                            Console.WriteLine("Good job! You have collected all hazelnuts!");
                            Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
                            return;
                        }
                    }
                    else if (field[nextRow, nextCol] == '*')
                    {
                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 's';
                    }
                    else if (field[nextRow, nextCol] == 't')
                    {
                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 's';
                        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                        Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
                        return;
                    }

                    playerRow = nextRow;
                    playerCol = nextCol;

                   //PrintField(field);
                }
                else if (currComand == "left")
                {
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow;
                    nextCol = currCol - 1;

                    bool isCorrdinateCorect = CkeckCoordinate(field, nextRow, nextCol);
                    if (!isCorrdinateCorect)
                    {
                        Console.WriteLine("The squirrel is out of the field.");
                        Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
                        return;
                    }


                    if (field[nextRow, nextCol] == 'h')
                    {
                        hazelnuts++;
                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 's';
                        if (hazelnuts == 3)
                        {
                            Console.WriteLine("Good job! You have collected all hazelnuts!");
                            Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
                            return;
                        }
                    }
                    else if (field[nextRow, nextCol] == '*')
                    {
                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 's';
                    }
                    else if (field[nextRow, nextCol] == 't')
                    {
                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 's';
                        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                        Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
                        return;
                    }

                    playerRow = nextRow;
                    playerCol = nextCol;

                    //PrintField(field);
                }
                else if (currComand == "right")
                {
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow;
                    nextCol = currCol + 1;

                    bool isCorrdinateCorect = CkeckCoordinate(field, nextRow, nextCol);
                    if (!isCorrdinateCorect)
                    {
                        Console.WriteLine("The squirrel is out of the field.");
                        Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
                        return;
                    }


                    if (field[nextRow, nextCol] == 'h')
                    {
                        hazelnuts++;
                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 's';
                        if (hazelnuts == 3)
                        {
                            Console.WriteLine("Good job! You have collected all hazelnuts!");
                            Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
                            return;
                        }
                    }
                    else if (field[nextRow, nextCol] == '*')
                    {
                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 's';
                    }
                    else if (field[nextRow, nextCol] == 't')
                    {
                        field[currRow, currCol] = '*';
                        field[nextRow, nextCol] = 's';
                        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                        Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
                        return;
                    }

                    playerRow = nextRow;
                    playerCol = nextCol;

                    //PrintField(field);
                }


            }

            Console.WriteLine("There are more hazelnuts to collect.");
            Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
        }

        private static bool CkeckCoordinate(char[,] field, int nextRow, int nextCol)
        {
            return nextRow >= 0 && nextRow < field.GetLength(0)
                && nextCol >= 0 && nextCol < field.GetLength(1);
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
                Console.WriteLine(sb.ToString());
            }
        }
    }
}