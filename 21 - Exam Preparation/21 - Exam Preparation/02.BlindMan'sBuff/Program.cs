namespace _02.BlindMan_sBuff
{
    /*
5 8 
- - - O - P - O
- P - O O - - -
- - - - - - O -
- P B - O - - O
- - - O - - - -
up
up
left
Finish
     */
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] fieldSize = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] field = new char[fieldSize[0], fieldSize[1]];

            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < field.GetLength(0); row++)
            {
                char[] inputElements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = inputElements[col];

                    if (field[row, col] == 'B')
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
            int tochedOpponets = 0;
            int moves = 0;

            string token = string.Empty;
            while ((token = Console.ReadLine())!= "Finish")
            {
                if(token == "up")
                {
                    moves++;
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow - 1;
                    nextCol = currCol;

                    bool isCorrdinateCorect = CkeckCoordinate(field, nextRow, nextCol);
                    if (!isCorrdinateCorect)
                    {
                        playerRow = currRow;
                        playerCol = currCol;
                        moves--;
                        continue;
                    }


                    if (field[nextRow, nextCol] == 'O')
                    {
                        playerRow = currRow;
                        playerCol = currCol;
                        moves--;
                        continue;
                    }
                    else if (field[nextRow, nextCol] == '-')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'B';
                    }
                    else if (field[nextRow, nextCol] == 'P')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'B';
                        tochedOpponets++;
                        if (tochedOpponets == 3)
                        {
                            PrintResult(tochedOpponets, moves);
                            return;
                        }
                    }

                    playerRow = nextRow;
                    playerCol = nextCol;

                    //PrintField(field);

                }
                else if (token == "down")
                {
                    moves++;
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow + 1;
                    nextCol = currCol;

                    bool isCorrdinateCorect = CkeckCoordinate(field, nextRow, nextCol);
                    if (!isCorrdinateCorect)
                    {
                        playerRow = currRow;
                        playerCol = currCol;
                        moves--;
                        continue;
                    }


                    if (field[nextRow, nextCol] == 'O')
                    {
                        playerRow = currRow;
                        playerCol = currCol;
                        moves--;
                        continue;
                    }
                    else if (field[nextRow, nextCol] == '-')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'B';
                    }
                    else if (field[nextRow, nextCol] == 'P')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'B';
                        tochedOpponets++;
                        if (tochedOpponets == 3)
                        {
                            PrintResult(tochedOpponets, moves);
                            return;
                        }
                    }

                    playerRow = nextRow;
                    playerCol = nextCol;

                    //PrintField(field);

                }

                else if (token == "left")
                {
                    moves++;
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow;
                    nextCol = currCol - 1;

                    bool isCorrdinateCorect = CkeckCoordinate(field, nextRow, nextCol);
                    if (!isCorrdinateCorect)
                    {
                        playerRow = currRow;
                        playerCol = currCol;
                        moves--;
                        continue;
                    }


                    if (field[nextRow, nextCol] == 'O')
                    {
                        playerRow = currRow;
                        playerCol = currCol;
                        moves--;
                        continue;
                    }
                    else if (field[nextRow, nextCol] == '-')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'B';
                    }
                    else if (field[nextRow, nextCol] == 'P')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'B';
                        tochedOpponets++;
                        if (tochedOpponets == 3)
                        {
                            PrintResult(tochedOpponets, moves);
                            return;
                        }
                    }

                    playerRow = nextRow;
                    playerCol = nextCol;

                    //PrintField(field);

                }

                else if (token == "right")
                {
                    moves++;
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow;
                    nextCol = currCol + 1;

                    bool isCorrdinateCorect = CkeckCoordinate(field, nextRow, nextCol);
                    if (!isCorrdinateCorect)
                    {
                        playerRow = currRow;
                        playerCol = currCol;
                        moves--;
                        continue;
                    }


                    if (field[nextRow, nextCol] == 'O')
                    {
                        playerRow = currRow;
                        playerCol = currCol;
                        moves--;
                        continue;
                    }
                    else if (field[nextRow, nextCol] == '-')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'B';
                    }
                    else if (field[nextRow, nextCol] == 'P')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'B';
                        tochedOpponets++;
                        if (tochedOpponets == 3)
                        {
                            PrintResult(tochedOpponets, moves);
                            return;
                        } 
                    }

                    playerRow = nextRow;

                    playerCol = nextCol;

                    //PrintField(field);

                }

            }

            PrintResult(tochedOpponets, moves);
        }

        private static void PrintResult(int tochedOpponets, int moves)
        {
            Console.WriteLine("Game over!");
            Console.WriteLine($"Touched opponents: {tochedOpponets} Moves made: {moves}");
           
        }

        private static bool CkeckCoordinate(char[,] field, int nextRow, int nextCol)
        {
            return nextRow >= 0 && nextRow < field.GetLength(0)
                && nextCol >= 0 && nextCol < field.GetLength(1);
        }
    }
}