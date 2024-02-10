
int matrixSize = int.Parse(Console.ReadLine());

int rows = matrixSize;
int cols = matrixSize;

string[,] matrix = new string[rows, cols];



for (int i = 0; i < rows; i++)
{
    string inputString = Console.ReadLine();
    string[] inputStingArray = new string[matrixSize];
    int counter = 0;

    foreach (var item in inputString)
    {
        inputStingArray[counter] = item.ToString();
        counter++;
    }

    for (int j = 0; j < cols; j++)
    { 
            matrix[i,j] = inputStingArray[j];
    }
    
}

string searchSymbol = Console.ReadLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (searchSymbol == matrix[i, j])
        {
            Console.WriteLine($"({i}, {j})");
            return;
        }
    }
}
Console.WriteLine($"{searchSymbol} does not occur in the matrix");
