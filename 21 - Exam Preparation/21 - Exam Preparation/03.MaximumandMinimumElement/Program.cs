

int numberCycles = int.Parse(Console.ReadLine());
Stack<int> stack = new Stack<int>();

for (int i = 0; i < numberCycles; i++)
{
    int[] commands = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    int command = commands[0];

    if (command == 1)
    {
        int number = commands[1];
        stack.Push(number);
    }
    else if (command == 2)
    {
        stack.Pop();
    }
    else if (command == 3
        && stack.Any())
    {
        int maxElement = stack.Max();
        Console.WriteLine(maxElement);
    }
    else if (command == 4
         && stack.Any())
    {
        int minElement = stack.Min();
        Console.WriteLine(minElement);
    }

}

string finalResiult = string.Empty;
while (stack.Any())
{ 
    finalResiult += stack.Pop() + ", ";
}

Console.WriteLine(finalResiult.TrimEnd(',',' '));