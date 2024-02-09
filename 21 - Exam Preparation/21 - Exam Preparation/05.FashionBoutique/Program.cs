int[] inputclothes = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Stack<int>  clothes = new Stack<int>(inputclothes);

int boxCapatiy = int.Parse(Console.ReadLine());

int boxCounter = 0 ;
int currBoxCapacity = 0;


while (clothes.Any())
{   
    int currClothes = clothes.Peek();
    if (currClothes <= currBoxCapacity)
    {
        currBoxCapacity -= currClothes ;
        clothes.Pop();
    }
    else
    {
        currBoxCapacity = boxCapatiy;
        boxCounter++;
    }

}

Console.WriteLine(boxCounter);
