namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumber = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            
            List<int> stringNumber = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Queue<int> numbers = new Queue<int>();

            int enqueueNumbers = inputNumber[0];
            int dequeueNumbers = inputNumber[1];
            int checkNumber = inputNumber[2];   

            for (int i = 0; i < enqueueNumbers; i++) 
            {
                numbers.Enqueue(stringNumber[i]);
            }

            for (int i = 0; i < dequeueNumbers; i++)
            {
                numbers.Dequeue();
            }
            if (numbers.Count <= 0)
            {
                Console.WriteLine(0);
                return;
            }
            int currNumberLow = int.MaxValue;
            while (numbers.Any())
            {
                int currNumber = numbers.Dequeue();
                if (currNumber == checkNumber)
                {
                    Console.WriteLine("true");
                    return;
                }
                else if (currNumber < currNumberLow ) 
                {
                    currNumberLow = currNumber;
                }

            }

            Console.WriteLine(currNumberLow);
        }
    }
}