
int[] matrixSize = Console.ReadLine()
    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = matrixSize[0];
int cols = matrixSize[1];

int[,] matrix = new int [rows, cols];

for (int i = 0; i < rows; i++)
{
    int[] inputValue = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();


    for (int j = 0; j < cols; j++)
    {
        matrix[i,j] = inputValue[j];
    }
}

for (int i = 0; i < matrix.GetLength(1); i++)
{   int sumOfRols = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        sumOfRols += matrix[j,i];

    }
    Console.WriteLine(sumOfRols);
}