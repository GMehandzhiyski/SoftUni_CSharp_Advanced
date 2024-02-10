
int matrixSize = int.Parse(Console.ReadLine());

int cols = matrixSize;
int rols = matrixSize;

int[,] matrix = new int[cols, rols];

for (int i = 0; i < cols; i++)
{
    int[] inputValue = Console.ReadLine()
           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

    for (int j = 0; j < rols; j++)
    {
        matrix[i, j] = inputValue[j];
    }
}
int sumPrimariDiagonal = 0;
for (int i = 0; i < cols; i++)
{
    sumPrimariDiagonal += matrix[i, i];
}

Console.WriteLine(sumPrimariDiagonal);