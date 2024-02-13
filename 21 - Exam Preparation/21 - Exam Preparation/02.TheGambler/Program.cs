using System.Text;

namespace _02.TheGambler
{

/*
4
W-GW
W--W
--P-
----
*/

    internal class Program
    {
        static void Main(string[] args)
        {
            int gameBoardSize = int.Parse(Console.ReadLine());
            string argumets = string.Empty;
            int amount = 100;
            int nextRow = 0;
            int nextCol = 0;

            string[,] board = new string[gameBoardSize,gameBoardSize];
            int playerRow = 0;
            int playerCol = 0;
            for (int row = 0; row < board.GetLength(0); row++)
            {
                string inputBoard = Console.ReadLine();
                    
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = inputBoard[col].ToString();
                    if (board[row, col] == "G")
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

          
            while ((argumets = Console.ReadLine())!= "end")
            {
                if (argumets == "up")
                {
                    nextRow = playerRow - 1;
                    nextCol = playerCol;

                    bool isIndexValid = CheckIndex(board, nextRow, nextCol);
                    if (!isIndexValid)
                    {
                        Console.WriteLine("Game over! You lost everything!");
                        return;
                    }

                    amount = CalculateAmount(board, nextRow, nextCol, amount);

                    board[playerRow, playerCol] = "-";
                    board[playerRow - 1, playerCol] = "G";
                    playerRow = nextRow;
                    playerCol = nextCol;

                }
                else if (argumets == "down")
                {
                    nextRow = playerRow + 1;
                    nextCol = playerCol;

                    bool isIndexValid = CheckIndex(board, nextRow, nextCol);
                    if (!isIndexValid)
                    {
                        Console.WriteLine("Game over! You lost everything!");
                        return;
                    }

                    amount = CalculateAmount(board, nextRow, nextCol, amount);

                    board[playerRow, playerCol] = "-";
                    board[playerRow + 1, playerCol] = "G";
                    playerRow = nextRow;
                    playerCol = nextCol;
                }
                else if (argumets == "left")
                {
                    nextRow = playerRow;
                    nextCol = playerCol - 1;

                    bool isIndexValid = CheckIndex(board, nextRow, nextCol);
                    if (!isIndexValid)
                    {
                        Console.WriteLine("Game over! You lost everything!");
                        return;
                    }

                    amount = CalculateAmount(board, nextRow, nextCol, amount);

                    board[playerRow, playerCol] = "-";
                    board[playerRow, playerCol - 1] = "G";
                    playerRow = nextRow;
                    playerCol = nextCol;
                }
                else if (argumets == "right")
                {
                    nextRow = playerRow;
                    nextCol = playerCol + 1;

                    bool isIndexValid = CheckIndex(board, nextRow, nextCol);
                    if (!isIndexValid)
                    {
                        Console.WriteLine("Game over! You lost everything!");
                        return;
                    }

                    amount = CalculateAmount(board, nextRow, nextCol, amount);

                    board[playerRow, playerCol] = "-";
                    board[playerRow, playerCol + 1] = "G";
                    playerRow = nextRow;
                    playerCol = nextCol;
                }

                if (amount <= 0)
                {
                    Console.WriteLine("Game over! You lost everything!");
                    return;
                }

                if (amount >= 100000)
                {
                    Console.WriteLine("You win the Jackpot!");
                    Console.WriteLine($"End of the game. Total amount: {amount}$");
                    PrintBoard(board);
                    Environment.Exit(0);
                }
               Console.WriteLine();
               PrintBoard(board);
            }

            Console.WriteLine($"End of the game. Total amount: {amount}$");
            PrintBoard(board);

        }

        private static void PrintBoard(string[,] board)
        {
            
            for (int row = 0; row < board.GetLength(0); row++)
            {
                StringBuilder sb = new StringBuilder();
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    sb.Append(board[row, col]);
                   
                }
                 Console.WriteLine(sb.ToString().TrimEnd());
            }
           
        }

        private static int CalculateAmount(string[,] board, int nextRow, int nextCol, int amount)
        {
            string takeChar = board[nextRow, nextCol];

            if (takeChar == "W")
            {
                amount += 100;
            }
            else if (takeChar == "P")
            {
                amount -= 200;
            }
            else if (takeChar == "J")
            {
                amount += 100000;
             
            }

            return amount;
        }

        private static bool CheckIndex(string[,] board, int nextRow, int nextCol)
        {
            return nextRow >= 0 && nextRow < board.GetLength(0)
                && nextCol >= 0 && nextCol < board.GetLength(1);
        }
    }
}