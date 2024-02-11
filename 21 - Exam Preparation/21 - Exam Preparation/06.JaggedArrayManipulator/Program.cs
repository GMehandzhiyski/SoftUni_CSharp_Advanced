

using System.Reflection.Metadata.Ecma335;

int rowSize = int.Parse(Console.ReadLine());

int[][] matrix = new int[rowSize][];

for (int row = 0; row < rowSize; row++)
{
    int[] inputString = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    matrix[row] = inputString;
}

for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
    if (matrix[row].Length == matrix[row + 1].Length)
    {
        for (int col = 0; col < matrix[row].Length; col++)
        {
            matrix[row][col] *= 2;
            matrix[row + 1][col] *= 2;
        }
    }
    else
    {
        for (int col = 0; col < matrix[row].Length; col++)
        {
            matrix[row][col] /= 2;
        }
        for (int col = 0; col < matrix[row + 1].Length; col++)
        {
            matrix[row + 1][col] /= 2;
        }
    }
}

string arguments = string.Empty; 
while ((arguments = Console.ReadLine()) != "End") 
{
    string[] commands = arguments
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    bool isCoordinateIsValid = CheckCoordinate(matrix, commands);
    if (commands[0] == "Add"
        && isCoordinateIsValid )
    {
        matrix[int.Parse(commands[1])][int.Parse(commands[2])] += int.Parse(commands[3]); 
    }
    if (commands[0] == "Subtract"
        && isCoordinateIsValid)
    {
        matrix[int.Parse(commands[1])][int.Parse(commands[2])] -= int.Parse(commands[3]);
    }
}

bool CheckCoordinate(int[][] matrix, string[] commands)
{
    return commands.Length == 4
        && int.Parse(commands[1]) >= 0 && int.Parse(commands[1]) < matrix.GetLength(0)
        && int.Parse(commands[2]) >= 0 && int.Parse(commands[2]) < matrix.GetLength(0);
}

PrintMatrix(matrix);

void PrintMatrix(int[][] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix[row].Length; col++)
        {
            Console.Write($"{matrix[row][col]} ");
        }
        Console.WriteLine();
    }
}