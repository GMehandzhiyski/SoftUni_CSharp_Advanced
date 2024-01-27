string text = Console.ReadLine();

Func<string, bool> check = c => c[0] == c.ToUpper()[0];

string[] finalText = text
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Where(check)
    .ToArray();
foreach (var item in finalText)
{
    Console.WriteLine(item);
}
    