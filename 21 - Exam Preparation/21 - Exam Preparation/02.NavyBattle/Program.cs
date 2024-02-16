using System.Text;

namespace _02.NavyBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

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

                    if (field[row, col] == 'S')
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
            int nextRow = 0;
            int nextCol = 0;
            string token = string.Empty;
            int mineHits = 0;
            int battleCruiser = 0;
            while (true)
            {
                string currComand = Console.ReadLine();

                if (currComand == "up")
                {
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow - 1;
                    nextCol = currCol;

                    //bool isCorrdinateCorect = CkeckCoordinate(field, nextRow, nextCol);
                    //if (!isCorrdinateCorect)
                    //{
                    //    Console.WriteLine("The squirrel is out of the field.");
                    //    Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
                    //    return;
                    //}


                    if (field[nextRow, nextCol] == 'C')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'S';
                        battleCruiser++;
                        if (battleCruiser == 3)
                        {
                            Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                            PrintField(field);
                            return;
                        }
                    }
                    else if (field[nextRow, nextCol] == '*')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'S';
                        mineHits++;
                        if (mineHits == 3)
                        {
                            Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{nextRow}, {nextCol}]!");
                            PrintField(field);
                            return;
                        }
                       
                    }
                    else if (field[nextRow, nextCol] == '-')//no
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'S';
                    }

                    playerRow = nextRow;
                    playerCol = nextCol;

                  //  PrintField(field);

                }

                else if (currComand == "down")
                {
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow + 1;
                    nextCol = currCol;

                    //bool isCorrdinateCorect = CkeckCoordinate(field, nextRow, nextCol);
                    //if (!isCorrdinateCorect)
                    //{
                    //    Console.WriteLine("The squirrel is out of the field.");
                    //    Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
                    //    return;
                    //}


                    if (field[nextRow, nextCol] == 'C')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'S';
                        battleCruiser++;
                        if (battleCruiser == 3)
                        {
                            Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                            PrintField(field);
                            return;
                        }
                    }
                    else if (field[nextRow, nextCol] == '*')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'S';
                        mineHits++;
                        if (mineHits == 3)
                        {
                            Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{nextRow}, {nextCol}]!");
                            PrintField(field);
                            return;
                        }

                    }
                    else if (field[nextRow, nextCol] == '-')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'S';
                    }

                    playerRow = nextRow;
                    playerCol = nextCol;

                   // PrintField(field);

                }

                else if (currComand == "left")
                {
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow;
                    nextCol = currCol - 1;

                    //bool isCorrdinateCorect = CkeckCoordinate(field, nextRow, nextCol);
                    //if (!isCorrdinateCorect)
                    //{
                    //    Console.WriteLine("The squirrel is out of the field.");
                    //    Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
                    //    return;
                    //}


                    if (field[nextRow, nextCol] == 'C')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'S';
                        battleCruiser++;
                        if (battleCruiser == 3)
                        {
                            Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                            PrintField(field);
                            return;
                        }
                    }
                    else if (field[nextRow, nextCol] == '*')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'S';
                        mineHits++;
                        if (mineHits == 3)
                        {
                            Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{nextRow}, {nextCol}]!");
                            PrintField(field);
                            return;
                        }

                    }
                    else if (field[nextRow, nextCol] == '-')//no
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'S';
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

                    //bool isCorrdinateCorect = CkeckCoordinate(field, nextRow, nextCol);
                    //if (!isCorrdinateCorect)
                    //{
                    //    Console.WriteLine("The squirrel is out of the field.");
                    //    Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
                    //    return;
                    //}


                    if (field[nextRow, nextCol] == 'C')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'S';
                        battleCruiser++;
                        if (battleCruiser == 3)
                        {
                            Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                            PrintField(field);
                            return;
                        }
                    }
                    else if (field[nextRow, nextCol] == '*')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'S';
                        mineHits++;
                        if (mineHits == 3)
                        {
                            Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{nextRow}, {nextCol}]!");
                            PrintField(field);
                            return;
                        }

                    }
                    else if (field[nextRow, nextCol] == '-')//no
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'S';
                    }

                    playerRow = nextRow;
                    playerCol = nextCol;

                    //PrintField(field);

                }


            }
            
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