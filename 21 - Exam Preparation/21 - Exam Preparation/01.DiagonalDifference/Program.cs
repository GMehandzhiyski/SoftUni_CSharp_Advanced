
using System.Linq.Expressions;

int matrixSize = int.Parse(Console.ReadLine());

int[,] matrix = new int[matrixSize, matrixSize];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] inputString = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = inputString[j];
    }
}
int sumFirstDiadon = 0;
int sumSecondDiadon = 0;
for (int row = 0; row < matrix.GetLength(0); row++)
{
    sumFirstDiadon += CalcolateSum(row, matrix);
}
int roww = 0; 
for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
{
    sumSecondDiadon += matrix[roww, col];
    roww++;
}

Console.WriteLine(Math.Abs(sumFirstDiadon - sumSecondDiadon));

int CalcolateSum(int row, int[,] matrix)
{

    return sumFirstDiadon = matrix[row, row];
    
}