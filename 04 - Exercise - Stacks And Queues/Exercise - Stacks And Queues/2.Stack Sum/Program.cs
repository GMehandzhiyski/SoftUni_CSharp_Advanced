namespace _2.Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack <int> numbersStack = new Stack<int>(inputNumbers);

            string argumnets ;   
            while ((argumnets = Console.ReadLine().ToLower()) != "end" ) 
            {
                string[] commands = argumnets
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commands[0];
                int numberToRemove = int.Parse(commands[1]);

                if (command == "add")
                {
                    numbersStack.Push(int.Parse(commands[1]));
                    numbersStack.Push(int.Parse(commands[2]));
                }
                else if (command == "remove"
                    && numberToRemove <= numbersStack.Count)
                {
                    
                    for (int i = 0; i < numberToRemove; i++)
                    {
                        numbersStack.Pop();
                    }

                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine($"Sum: {numbersStack.Sum()}");
        }
    }
}