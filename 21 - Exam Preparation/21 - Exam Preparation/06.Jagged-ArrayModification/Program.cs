

int rowsSize = int.Parse(Console.ReadLine());

int[][] matrix = new int[rowsSize][];
matrix[0] = new int[rowsSize];

for (int i = 0; i < rowsSize; i++)
{
    int[] inputCols = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    matrix[i] = inputCols ;
}

string argument = string.Empty;
while ((argument = Console.ReadLine()) != "END")
{
    string[] commands = argument
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string command = commands[0];
    int currRow = int.Parse(commands[1]);
    int currCol = int.Parse(commands[2]);
    int currValue = int.Parse(commands[3]);

    bool isCoordinateIsValid = CheckCoordinate(matrix, currRow, currCol);
    if (!isCoordinateIsValid)
    {
        Console.WriteLine("Invalid coordinates");
        continue;
    }

    if (command == "Add")
    {
        matrix[currRow][currCol] += currValue;
    }
    else if (command == "Subtract")
    {
        matrix[currRow][currCol] -= currValue;
    }
}

PrintMatrix(matrix);


bool CheckCoordinate(int[][] matrix, int currRow, int currCol)
{
    return  (currRow < matrix.Length && currRow >= 0)
            && (currCol < matrix[currRow].Length && currCol >= 0);

}
void PrintMatrix(int[][] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = 0; j < matrix[i].Length; j++)
        {
            Console.Write($"{matrix[i][j]} ");
        }
        Console.WriteLine();
    }
}
