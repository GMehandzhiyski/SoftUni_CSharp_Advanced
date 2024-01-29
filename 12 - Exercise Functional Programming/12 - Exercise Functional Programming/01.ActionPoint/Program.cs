
string[] inputNames = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();


Action<string> names = names =>
{
    foreach (var name in names)
    {
        Console.WriteLine(name);
    }
};