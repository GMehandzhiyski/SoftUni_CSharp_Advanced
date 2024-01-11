namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowSize = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rowSize][];

            for (int row = 0; row < rowSize; row++)
            {
                int[] inputNumbers = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                    jagged[row] = inputNumbers;
               
            }
            ;
        }
    }
}