using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

string[] inputSetLenght = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

int firstSetLenght = int.Parse(inputSetLenght[0]);
int secondSetLenght = int.Parse(inputSetLenght[1]);

HashSet<int> firstSet = new ();
HashSet<int> secondSet = new();

for (int i = 0; i < firstSetLenght; i++)
{
    int inputNumber = int.Parse(Console.ReadLine());
    firstSet.Add(inputNumber);
}

for (int i = 0; i < secondSetLenght; i++)
{
    int inputNumber = int.Parse(Console.ReadLine());
    secondSet.Add(inputNumber);
}

firstSet.IntersectWith(secondSet);

Console.WriteLine($"{string.Join(" ",firstSet)}");