namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] startNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)  
                .ToArray();

            int[] inputString = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int pushElementsNumbers = startNumbers[0];
            int popElementsNUmbers = startNumbers[1];
            int checkNumber = startNumbers[2];

            Stack<int> number = new Stack<int>();

            for (int i = 0; i < pushElementsNumbers; i++)
            {
                number.Push(inputString[i]);
            }

            for (int i = 0; i < popElementsNUmbers; i++)
            {
                number.Pop();
            }

            int currLowNumber = int.MaxValue;
            if (number.Count <= 0) 
            {
                Console.WriteLine(0);
                return;
            }
            while (number.Any())
            {
                int currNumber = number.Pop();
                if (currNumber == checkNumber)
                {
                    Console.WriteLine("true");
                    return;
                }

                else if (currLowNumber > currNumber)
                { 
                    currLowNumber = currNumber; 
                }
            }

            Console.WriteLine(currLowNumber);
            
        }
    }
}