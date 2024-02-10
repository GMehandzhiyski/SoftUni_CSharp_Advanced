
int[] matrixSize = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
string [,] matrix = new string[matrixSize[0], matrixSize[1]];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string[] inputString = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = inputString[col];
    }
}

string argument = string.Empty; 
while ((argument = Console.ReadLine()) != "END")
{
    string[] commands = argument
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    bool isInputIsCorect = CheckInput(matrix, commands );
    if (!isInputIsCorect)
    {
        Console.WriteLine("Invalid input!");
        continue;
    }

    int row1 = int.Parse(commands[1]);
    int col1 = int.Parse(commands[2]);
    int row2 = int.Parse(commands[3]);
    int col2 = int.Parse(commands[4]);

    (matrix[row1, col1], matrix[row2, col2]) = (matrix[row2, col2], matrix[row1, col1]);

    PrintMatrix(matrix);
}

void PrintMatrix(string[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write($"{matrix[row,col]} ");
        }
        Console.WriteLine();
    }
}

bool CheckInput(string[,] matrix, string[] commands)
{
    return commands.Length == 5
            && commands[0] == "swap"
            && (int.Parse(commands[1]) >= 0 && int.Parse(commands[1]) < matrix.GetLength(0))
            && (int.Parse(commands[2]) >= 0 && int.Parse(commands[2]) < matrix.GetLength(1))
            && (int.Parse(commands[3]) >= 0 && int.Parse(commands[3]) < matrix.GetLength(0))
            && (int.Parse(commands[4]) >= 0 && int.Parse(commands[4]) < matrix.GetLength(1));
}

