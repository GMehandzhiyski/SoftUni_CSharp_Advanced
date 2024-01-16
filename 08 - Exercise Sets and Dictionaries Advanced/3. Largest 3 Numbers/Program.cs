namespace _3._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] sorted = numbers.OrderByDescending(n => n)
                .ToArray();    

            for (int i = 0; i < sorted.Length && i < 3; i++) 
            {
                
                Console.Write(string.Join("  ", sorted[i]) + " ");
            }
        }
    }
}