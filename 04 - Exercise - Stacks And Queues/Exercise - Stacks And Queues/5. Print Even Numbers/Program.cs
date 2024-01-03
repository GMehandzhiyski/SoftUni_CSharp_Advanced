namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] inputNumber = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray(); 


            Queue<int> numberQueue = new Queue<int>(inputNumber);

            string finalString = string.Empty;

            while (numberQueue.Any())
            {
                

                int currNumber = numberQueue.Dequeue();
                if (currNumber % 2 == 0)
                {
                    finalString += currNumber + ", ";
                }

            }
            Console.WriteLine(finalString.TrimEnd(',', ' '));
        }
    }
}