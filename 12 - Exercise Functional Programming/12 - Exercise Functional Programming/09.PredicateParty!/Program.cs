using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

List<string> names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string argumets = string.Empty;
while ((argumets = Console.ReadLine()) != "Party!")
{
    string[] commnds = argumets
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string command = commnds[0];
    string filter = commnds[1];
    string token = commnds[2];


    if (command == "Remove")
    {
        names.RemoveAll(GetPredicate(filter,token));
    }
    else if(command == "Double")
    {
        List<string> namesToDouble = names.FindAll(GetPredicate(filter,token));

        foreach (var currName in namesToDouble) 
        {
            int index = names.FindIndex(name => name == currName);
            names.Insert(index, currName);
        }
    }
}

if (names.Any())
{
    Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}
static Predicate<string> GetPredicate(string filter, string token)
{
    switch (filter)
    {
        case "StartsWith":
            return name => name.StartsWith(token);
        case "EndsWith":
            return name => name.EndsWith(token);
        case "Length":
            return name => name.Length == (int.Parse(token));
        default: return null;
    }
}