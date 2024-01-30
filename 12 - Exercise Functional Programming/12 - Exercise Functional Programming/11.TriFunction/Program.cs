int number = int.Parse(Console.ReadLine());

List<string> names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

Func<List<string>, int, string> foundName = (names, number) =>
{
    foreach (var name in names)
    {
        int nameSum = 0;
        foreach (var chName in name)
        {
            nameSum += chName;
        }

        if (nameSum >= number)
        {
            return name;
        }
    }
    return default;
};


string name = foundName(names, number);
Console.WriteLine(name);