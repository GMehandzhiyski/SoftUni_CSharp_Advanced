/*
3 4
A B B D
E B B B
I J B B
*/


int[] matrixSize = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string[,] matrix = new string[matrixSize[0], matrixSize[1]];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string [] inputString = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row,col] = inputString[col]; 
    }
}
int countCell = 0;
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        bool isIndexInRange = CheckIndexRange(matrix, row, col);
       
        if (!isIndexInRange)
        {
            continue;
        }
        bool isFoundCell = CheckCell(matrix, row, col);
        if (isFoundCell)
        {
            countCell++;
        }

    }
}


Console.WriteLine(countCell);
bool CheckCell(string[,] matrix, int row, int col)
{
    string e1 = matrix[row, col];
    string e2 = matrix[row, col + 1];
    string e3 = matrix[row + 1, col];
    string e4 = matrix[row + 1, col + 1];



    return e1 == e2 
           && e3 == e4
           && e1 == e4 ;

}

bool CheckIndexRange(string[,] matrix, int row, int col)
{
    int rowLenght = matrix.GetLength(0);
    int colLenght = matrix.GetLength(1);

    return row + 1 < rowLenght
           &&  col +  1 < colLenght;
}