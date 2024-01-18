
SortedDictionary<char, int> symbolsCount = new();
string inputString = Console.ReadLine();

foreach (var currSymbol in inputString)
{
    if (!symbolsCount.ContainsKey(currSymbol))
    {
        symbolsCount.Add(currSymbol, 0);
    }
    symbolsCount[currSymbol]++;
}
PrintResult(symbolsCount);

void PrintResult(SortedDictionary<char, int> symbolsCount)
{
    foreach (var currSymbol in symbolsCount)
    {
        Console.WriteLine($"{currSymbol.Key}: {currSymbol.Value} time/s");
    }
}