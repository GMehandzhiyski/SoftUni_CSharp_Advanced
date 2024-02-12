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

            string argumets = string.Empty;
            int amount = 100;
            while ((argumets = Console.ReadLine())!= "end")
            {
                if (argumets == "up")
                {
                    int nextRow = playerRow + 1;
                    int nextCol = playerCol;

                    bool isIndexValid = CheckIndex(board, nextRow, nextCol);
                    if (!isIndexValid)
                    {
                        Console.WriteLine("Game over! You lost everything!");
                        return;
                    }

                    amount = CalculateAmount(board, nextRow, nextCol, amount);
                    
                    if (amount < 0)
                    {
                        Console.WriteLine("Game over! You lost everything!");
                        return;
                    }

                    board[playerRow, playerCol] = "-";
                    board[playerRow, playerCol + 1] = "G";
                    playerRow = playerRow;
                    playerCol = playerCol + 1;

                }
                else if (argumets == "down")
                {

                }
                else if (argumets == "left")
                {

                }
                else if (argumets == "right")
                {

                }


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
                Console.WriteLine("You win the Jackpot!");
                Console.WriteLine($" End of the game.Total amount: {amount}$");
                Environment.Exit(0);
            }

            return amount;
        }

        private static bool CheckIndex(string[,] board, int nextRow, int nextCol)
        {
            return nextRow < 0 && nextRow > board.GetLength(0)
                && nextCol < 0 && nextCol > board.GetLength(1);
        }
    }
}