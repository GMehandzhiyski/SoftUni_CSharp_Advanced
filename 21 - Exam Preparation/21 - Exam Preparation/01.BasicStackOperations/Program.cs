


int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int nPush = numbers[0];
int nPop = numbers[1];
int xCheck = numbers[2];

int[] secondNumbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Stack<int> stack = new Stack<int>();    
for (int i = 0; i < nPush; i++)
{
    stack.Push(secondNumbers[i]);
}

for (int i = 0; i < nPop; i++)
{
    stack.Pop();
}

int smalNumber = int.MaxValue;

if (stack.Count == 0)
{
    Console.WriteLine(0);
    return;
}
while (stack.Any())
{
    int currNumber  = stack.Pop();

    if (currNumber == xCheck)
    {
        Console.WriteLine("true");
        return;
    }
    if (currNumber < smalNumber)
    {
        smalNumber = currNumber;
       
    }
}
Console.WriteLine(smalNumber);