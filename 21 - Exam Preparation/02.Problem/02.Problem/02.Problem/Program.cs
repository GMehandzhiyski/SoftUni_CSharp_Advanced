using System.Text;

namespace _02.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            

            char[,] field = new char[fieldSize, fieldSize];
           // int firstPlayerRow = 0;
           // int firstPlayerCol = 0;
            int playerRow = 0;
            int playerCol = 0;
            int enemyAircraftStart = 0;
            for (int row = 0; row < field.GetLength(0); row++)
            {
             
                string inputElements = Console.ReadLine();

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = inputElements[col];

                    if (field[row, col] == 'J')
                    {
                       // firstPlayerRow = row;
                      //  firstPlayerCol = col;
                        playerRow = row;
                        playerCol = col;
                    }
                    if (field[row, col] == 'E')
                    {
                        enemyAircraftStart++;
                     }
                }
            }

            int currRow = 0;
            int currCol = 0;
            int nextRow = 0;
            int nextCol = 0;
            //int  enemyAircraft = 0;
            int armour = 300;

            while (armour > 0
                && enemyAircraftStart > 0)// vrajest

            {  
                string token = Console.ReadLine();
                if (token == "up")
                {
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow - 1;
                    nextCol = currCol;

                    //bool isCoordinateIsValid = CheckValidCoordinate(field, nextRow, nextCol);
                    //if (!isCoordinateIsValid)
                    //{
                    //    Console.WriteLine("No more cheese for tonight!");
                    //    PrintField(field);
                    //    return;
                    //}


                    if (field[nextRow, nextCol] == '-')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'J';
                        playerRow = nextRow;
                        playerCol = nextCol;
                    }

                    else if (field[nextRow, nextCol] == 'E')
                    {

                        enemyAircraftStart--;
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'J';
                        playerRow = nextRow;
                        playerCol = nextCol;

                        if (enemyAircraftStart == 0)
                        {
                            Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                            PrintField(field);
                            return;
                        }
                        armour -= 100;
                        if (armour <= 0)
                        {
                            Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{playerRow}, {playerCol}]!");
                            PrintField(field);
                            return;
                        }
                    }
                    else if (field[nextRow, nextCol] == 'R')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'J';
                        armour = 300;
                        playerRow = nextRow;
                        playerCol = nextCol;
                    }
                   
                   

                    //PrintField(field);
                }

                else if (token == "down")
                {
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow + 1;
                    nextCol = currCol;

                    //bool isCoordinateIsValid = CheckValidCoordinate(field, nextRow, nextCol);
                    //if (!isCoordinateIsValid)
                    //{
                    //    Console.WriteLine("No more cheese for tonight!");
                    //    PrintField(field);
                    //    return;
                    //}


                    if (field[nextRow, nextCol] == '-')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'J';
                        playerRow = nextRow;
                        playerCol = nextCol;
                    }

                    else if (field[nextRow, nextCol] == 'E')
                    {

                        enemyAircraftStart--;
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'J';
                        playerRow = nextRow;
                        playerCol = nextCol;

                        if (enemyAircraftStart == 0)
                        {
                            Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                            PrintField(field);
                            return;
                        }
                        armour -= 100;
                        if (armour <= 0)
                        {
                            Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{playerRow}, {playerCol}]!");
                            PrintField(field);
                            return;
                        }
                    }
                    else if (field[nextRow, nextCol] == 'R')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'J';
                        armour = 300;
                        playerRow = nextRow;
                        playerCol = nextCol;
                    }



                    //PrintField(field);
                }
                if (token == "left")
                {
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow;
                    nextCol = currCol -1;

                    //bool isCoordinateIsValid = CheckValidCoordinate(field, nextRow, nextCol);
                    //if (!isCoordinateIsValid)
                    //{
                    //    Console.WriteLine("No more cheese for tonight!");
                    //    PrintField(field);
                    //    return;
                    //}


                    if (field[nextRow, nextCol] == '-')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'J';
                        playerRow = nextRow;
                        playerCol = nextCol;
                    }

                    else if (field[nextRow, nextCol] == 'E')
                    {

                        enemyAircraftStart--;
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'J';
                        playerRow = nextRow;
                        playerCol = nextCol;

                        if (enemyAircraftStart == 0)
                        {
                            Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                            PrintField(field);
                            return;
                        }
                        armour -= 100;
                        if (armour <= 0)
                        {
                            Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{playerRow}, {playerCol}]!");
                            PrintField(field);
                            return;
                        }
                    }
                    else if (field[nextRow, nextCol] == 'R')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'J';
                        armour = 300;
                        playerRow = nextRow;
                        playerCol = nextCol;
                    }



                    //PrintField(field);
                }
                if (token == "right")
                {
                    currRow = playerRow;
                    currCol = playerCol;
                    nextRow = currRow;
                    nextCol = currCol +1;

                    //bool isCoordinateIsValid = CheckValidCoordinate(field, nextRow, nextCol);
                    //if (!isCoordinateIsValid)
                    //{
                    //    Console.WriteLine("No more cheese for tonight!");
                    //    PrintField(field);
                    //    return;
                    //}


                    if (field[nextRow, nextCol] == '-')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'J';
                        playerRow = nextRow;
                        playerCol = nextCol;
                    }

                    else if (field[nextRow, nextCol] == 'E')
                    {

                        enemyAircraftStart--;
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'J';
                        playerRow = nextRow;
                        playerCol = nextCol;

                        if (enemyAircraftStart == 0)
                        {
                            Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                            PrintField(field);
                            return;
                        }
                        armour -= 100;
                        if (armour <= 0)
                        {
                            Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{playerRow}, {playerCol}]!");
                            PrintField(field);
                            return;
                        }
                    }
                    else if (field[nextRow, nextCol] == 'R')
                    {
                        field[currRow, currCol] = '-';
                        field[nextRow, nextCol] = 'J';
                        armour = 300;
                        playerRow = nextRow;
                        playerCol = nextCol;
                    }



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
                Console.WriteLine(sb.ToString());
            }
        }


    }
}