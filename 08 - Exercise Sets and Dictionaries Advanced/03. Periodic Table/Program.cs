using System;
using System.Collections.Generic;
using System.Linq;

int counts = int.Parse(Console.ReadLine());
SortedSet<string> chemicalElemets = new(); 
//List<string> chemicalElementsList = new();

for (int i = 0; i < counts; i++)
{
    string[] inputString = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    foreach (var currElements in inputString)
    {
        chemicalElemets.Add(currElements);
         
    }
}

//chemicalElementsList = chemicalElemets.OrderBy(x => x).ToList();
PrintResult(chemicalElemets);

void PrintResult(SortedSet<string> chemicalElemets)
{
    foreach (var currElement in chemicalElemets)
    {
        Console.Write($"{string.Join("  ",currElement)} ");
    }
}