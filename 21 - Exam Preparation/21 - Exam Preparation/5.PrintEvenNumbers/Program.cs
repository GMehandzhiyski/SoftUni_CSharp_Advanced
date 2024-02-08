using System.Text;

int[] inputNumber = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Queue<int> queue = new(inputNumber);
string result = string.Empty;
while (queue.Any())
{
   int number = queue.Dequeue();

   
    if (number % 2 == 0)
    {
      result += number + ", ";
    }
}
Console.WriteLine(result.TrimEnd(',', ' '));