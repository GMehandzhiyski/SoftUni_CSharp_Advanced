
string numbers = Console.ReadLine();

Func<string, int> parse = p => int.Parse(p);

int[] finalResult = numbers 
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(parse)
    .ToArray();

Console.WriteLine(finalResult.Length);
Console.WriteLine(finalResult.Sum());