
string[] inputNames = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();


Action<string[]> names = inputNames =>
{
    foreach (var name in inputNames)
    {
        Console.WriteLine(name);
    }
};

names(inputNames);