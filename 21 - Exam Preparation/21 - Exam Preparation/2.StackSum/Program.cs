


int[] inputNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

Stack<int> stack = new Stack<int>(inputNumbers);    

string arguments = string.Empty;
while ((arguments = Console.ReadLine().ToLower()) != "end")
{
    string[] commands = arguments
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string command = commands[0];

    if (command == "add")
    {
        int numberOne = int.Parse(commands[1]);  
        int numberTwo = int.Parse(commands[2]); 
        stack.Push(numberOne);
        stack.Push(numberTwo);
    }

    if (command == "remove")
    {
        int removeNumber = int.Parse(commands[1]);

        for (int i = 0; i < removeNumber && stack.Count >= removeNumber; i++)
        {
            stack.Pop();
        }
    }
}
Console.WriteLine($"Sum: {stack.Sum()}");