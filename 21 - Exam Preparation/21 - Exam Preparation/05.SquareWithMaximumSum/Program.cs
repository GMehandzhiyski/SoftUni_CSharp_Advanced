int[] matrixSize = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = matrixSize[0];
int cols = matrixSize[1];

int[,] matrix = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    int[] inputNumbers = Console.ReadLine()
        .Split(", ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    for (int j = 0; j < cols; j++)
    {
        matrix[i,j] = inputNumbers[j];
    }
}
int element1 = 0;
int element2 = 0;
int element3 = 0;
int element4 = 0;
int sumOfElment = 0;
int currSumOfElements = 0; 
for (int row = 0; row < matrix.GetLength(0); row ++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        bool isIndexInRange = CheckIndex(matrix, row, col);
        if (isIndexInRange)
        {
            currSumOfElements = matrix[row, col] + 
                                matrix[row + 1, col] + 
                                matrix[row, col + 1] + 
                                matrix[row + 1, col + 1];
            if (currSumOfElements > sumOfElment)
            {
                element1 = matrix[row, col];
                element2 = matrix[row + 1, col];
                element3 = matrix[row, col + 1];
                element4 = matrix[row + 1, col + 1];
                sumOfElment = currSumOfElements;
            }
        }
    }
}

Console.WriteLine($"{element1} {element3}");
Console.WriteLine($"{element2} {element4}");
Console.WriteLine(sumOfElment);

bool CheckIndex(int[,] matrix, int row, int col)
{
    return row + 1 < matrix.GetLength(0)
           && col + 1 < matrix.GetLength(1);
}