namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumber = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> numberStack = new Stack<int>(inputNumber);



        }
    }
}