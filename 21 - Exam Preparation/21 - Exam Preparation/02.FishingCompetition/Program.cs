using System.Collections.Generic;
/*
4
---S
----
9-5-
34--
down
down
right
down
collect the nets
*/

namespace _02.FishingCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int playerRow = 0;
            int playerCol = 0;
            int target = 20;
            char[,] fishingArea = new char[matrixSize, matrixSize];

            for (int row = 0; row < fishingArea.GetLength(0); row++)
            {
                string inputArea = Console.ReadLine();

                for (int col = 0; col < fishingArea.GetLength(1); col++)
                {
                    fishingArea[row, col] = inputArea[col];
                    if (fishingArea[row, col] == 'S')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
            int currRow = 0;
            int currCol = 0;
            int nextRow = 0;
            int nextCol = 0;
            int least = 0;

            string argumnets = string.Empty;
            while ((argumnets = Console.ReadLine()) != "collect the nets")
            {
                if (argumnets == "up")
                {
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow - 1;
                    nextCol = currCol;

                    bool isCoordinateInArre = ChekcCoordinate(fishingArea,nextRow,nextCol);
                    if (isCoordinateInArre) 
                    {
                        nextRow = currRow - 1;
                        nextCol = currCol;

                        least += CheckCurrCoordinate(nextRow,nextCol,currRow, currCol, fishingArea);
                    }
                    else 
                    {
                        nextRow = fishingArea.GetLength(0) - 1;
                        nextCol = currCol;

                        least += CheckCurrCoordinate(nextRow, nextCol, currRow, currCol, fishingArea);

                     


                    }
                    playerRow = nextRow;
                    playerCol = nextCol;
                    fishingArea[currRow, currCol] = '-';
                    fishingArea[playerRow, playerCol] = 'S';

                   PrintFishingArea(fishingArea);

                }
                if (argumnets == "down")
                {
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow + 1;
                    nextCol = currCol;

                    bool isCoordinateInArre = ChekcCoordinate(fishingArea, nextRow, nextCol);
                    if (isCoordinateInArre)
                    {
                        nextRow = currRow + 1;
                        nextCol = currCol;

                        least += CheckCurrCoordinate(nextRow, nextCol, currRow, currCol, fishingArea);
                    }
                    else
                    {
                        nextRow = 0;
                        nextCol = currCol;

                        least += CheckCurrCoordinate(nextRow, nextCol, currRow, currCol, fishingArea);



                    }

                    playerRow = nextRow;
                    playerCol = nextCol;
                    fishingArea[currRow, currCol] = '-';
                    fishingArea[playerRow, playerCol] = 'S';

                  PrintFishingArea(fishingArea);
                }


                if (argumnets == "right")
                {
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow;
                    nextCol = currCol + 1;

                    bool isCoordinateInArre = ChekcCoordinate(fishingArea, nextRow, nextCol);
                    if (isCoordinateInArre)
                    {
                        nextRow = currRow ;
                        nextCol = currCol + 1;

                        least += CheckCurrCoordinate(nextRow, nextCol, currRow, currCol, fishingArea);
                    }
                    else
                    {
                        nextRow = currRow;
                        nextCol = 0;

                        least += CheckCurrCoordinate(nextRow, nextCol, currRow, currCol, fishingArea);
                    }

                    playerRow = nextRow;
                    playerCol = nextCol;
                    fishingArea[currRow, currCol] = '-';
                    fishingArea[playerRow, playerCol] = 'S';

                   // PrintFishingArea(fishingArea);
                }
                if (argumnets == "left")
                {
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow;
                    nextCol = currCol - 1;

                    bool isCoordinateInArre = ChekcCoordinate(fishingArea, nextRow, nextCol);
                    if (isCoordinateInArre)
                    {
                        nextRow = currRow;
                        nextCol = currCol - 1;

                        least += CheckCurrCoordinate(nextRow, nextCol, currRow, currCol, fishingArea);
                    }
                    else
                    {
                        nextRow = currRow;
                        nextCol = fishingArea.GetLength(1) - 1;

                        least += CheckCurrCoordinate(nextRow, nextCol, currRow, currCol, fishingArea);



                    }

                    playerRow = nextRow;
                    playerCol = nextCol;
                    fishingArea[currRow, currCol] = '-';
                    fishingArea[playerRow, playerCol] = 'S';

                   PrintFishingArea(fishingArea);
                }
            }
            if (least >= target)
            {
                Console.WriteLine("Success! You managed to reach the quota!");
                
            }
            else
            {
                Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {target - least} tons of fish more.");
               
            }
            Console.WriteLine($"Amount of fish caught: {least} tons.");
            PrintFishingArea(fishingArea);

        }





        private static void PrintFishingArea(char[,] fishingArea)
        {
            for (int i = 0; i < fishingArea.GetLength(0); i++)
            {
                for (int j = 0; j < fishingArea.GetLength(1); j++)
                {
                    Console.Write(fishingArea[i,j]);
                }
                Console.WriteLine();

            }
        }

        private static int CheckCurrCoordinate(int nextRow, int nextCol, int currRow, int currCol, char[,] fishingArea)
        {
            int currleast = 0;
            if (fishingArea[nextRow, nextCol] == 'W')
            {
                Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{nextRow},{nextCol}]");
                Environment.Exit(0);
            }
            if (char.IsDigit(fishingArea[nextRow, nextCol]))
            {
                currleast += (fishingArea[nextRow, nextCol] - 48);
            }
            return currleast;
        }

        private static bool ChekcCoordinate(char[,] fishingArea, int nextRow, int nextCol)
        {
            return nextRow >= 0 && nextRow < fishingArea.GetLength(0)
                   && nextCol >= 0 && nextCol < fishingArea.GetLength(1);
        }
    }
}