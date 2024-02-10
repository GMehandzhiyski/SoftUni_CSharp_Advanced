
int[] matrixSize = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string word = Console.ReadLine();
///string word = inputString;
char[,] matrix = new char[matrixSize[0], matrixSize[1]];
int counter = 0;
for (int row = 0; row < matrix.GetLength(0); row++)
{

    if (row % 2 == 0)
    {
        for (int col1 = 0; col1 < matrix.GetLength(1); col1++)
        {
            if (counter == word.Length)
            {
                counter = 0;
            }
            matrix[row, col1] = word[counter];
            counter++;
        }
    }
    else
    {
        for (int col2 = (matrix.GetLength(1)) - (1); col2 >= 0; col2--)
        {
            if (counter == word.Length)
            {
                counter = 0;
            }
            matrix[row, col2] = word[counter];
            counter++;
        }

    }

}
PrintMatrix(matrix);

void PrintMatrix(char[,] matrix)
{
    for ( int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row,col]);
        }
        Console.WriteLine();
    }
}