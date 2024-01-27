//4, 2, 1, 3, 5, 7, 1, 4, 2, 12

List<int> number = Console.ReadLine()
    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
    .Select(x => int.Parse(x))
    .Where(x => x % 2 == 0)
    .OrderBy(x => x)
    .ToList();

Console.WriteLine(String.Join(", ",number));