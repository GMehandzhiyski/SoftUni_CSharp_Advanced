


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

Queue<int> queue = new();
for (int i = 0; i < nPush; i++)
{
    queue.Enqueue(secondNumbers[i]);
}

for (int i = 0; i < nPop; i++)
{
    queue.Dequeue();
}

int smalNumber = int.MaxValue;

if (queue.Count == 0)
{
    Console.WriteLine(0);
    return;
}
while (queue.Any())
{
    int currNumber = queue.Dequeue();

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