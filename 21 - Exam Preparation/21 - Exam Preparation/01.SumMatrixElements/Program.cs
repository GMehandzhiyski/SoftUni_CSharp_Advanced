
int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

int rows = numbers[0];
int cols = numbers[1];

int[,] matrix = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    int[] inputRows = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

    for (int j = 0; j < cols; j++)
    {
        matrix[i,j] = inputRows[j];
    }

    

}
int sumOfElements = 0;
foreach (var currElment in matrix)
{
    sumOfElements += currElment;
}

Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));
Console.WriteLine(sumOfElements);