
int[] matrixSize = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[,] matrix = new int[matrixSize[0], matrixSize[1]];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] inputString = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = inputString[col];
    }
}
int biggerSum = 0;
int rowStartNewMatrix = 0;
int calStartNewMatrix = 0;
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        bool isIndexInRange = CheckIndex(matrix, row, col);
        if (!isIndexInRange)
        {
            continue;
        }

        int e00 = matrix[row, col];
        int e01 = matrix[row, col + 1];
        int e02 = matrix[row, col + 2];

        int e10 = matrix[row + 1, col];
        int e11 = matrix[row + 1, col + 1];
        int e12 = matrix[row + 1, col + 2];

        int e20 = matrix[row + 2, col];
        int e21 = matrix[row + 2, col + 1];
        int e22 = matrix[row + 2, col + 2];

        int currSum = e00 + e01 + e02 +
                      e10 + e11 + e12 +
                      e20 + e21 + e22;
        if (currSum > biggerSum)
        {
          biggerSum = currSum;
          rowStartNewMatrix = row;
          calStartNewMatrix = col;
        }
    }
}

Console.WriteLine($"Sum = {biggerSum}");

PrintMatrix(matrix,rowStartNewMatrix, calStartNewMatrix);
bool CheckIndex(int[,] matrix, int row, int col)
{

    return row + 2 < matrix.GetLength(0)
           && col + 2 <matrix.GetLength(1) ;
}
void PrintMatrix(int[,] matrix, int rowStartNewMatrix,int calStartNewMatrix)
{
    for (int row = rowStartNewMatrix; row < rowStartNewMatrix + 3; row++)
    {
        for (int col = calStartNewMatrix; col < calStartNewMatrix + 3; col++)
        {
            Console.Write($"{matrix[row, col]} ");
        }
        Console.WriteLine();
    }
}