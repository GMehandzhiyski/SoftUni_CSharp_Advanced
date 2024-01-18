using System;
using System.Collections.Generic;

int count = int.Parse(Console.ReadLine());
Dictionary<int, int> numbers = new();

for (int i = 0; i < count; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (!numbers.ContainsKey(number))
    {
        numbers.Add(number, 0);
    }
    numbers[number]++;
}

PrintResult(numbers);

void PrintResult(Dictionary<int, int> numbers)
{
    foreach (var currNumber in numbers)
    {
        if (currNumber.Value % 2 == 0)
        {
            Console.WriteLine(currNumber.Key);
            return;
        }
    }
}