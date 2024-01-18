using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

HashSet<string> names = new();
int counts = int.Parse(Console.ReadLine());

for (int i = 0; i < counts; i++)
{
    string name = Console.ReadLine();

    names.Add(name);
}

foreach (var currName in names)
{
    Console.WriteLine(currName);
}