
int foodPerDay = int.Parse(Console.ReadLine());

int[] inputOrdes = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Queue<int> orders = new(inputOrdes);

Console.WriteLine(orders.Max());
if (orders.Sum() <= foodPerDay)
{
    Console.WriteLine("Orders complete");
    return;
}


while (true)
{
    int currOrder = orders.Peek();
    if (currOrder < foodPerDay)
    {
        orders.Dequeue();
        foodPerDay -= currOrder;
    }
    else
    {
        break;
    }
}


string orderLeft = string.Empty;
while (orders.Any())
{
    orderLeft += orders.Dequeue() + " ";
}
Console.WriteLine($"Orders left: {orderLeft.TrimEnd(' ')}");
