int nameLenght = int.Parse(Console.ReadLine());    

List<string> names = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .ToList();

//Predicate<List<string>> checkLengt = names =>
              // names.All(name => name.Length <= nameLenght);

Func<List<string>,int,List<string>> foundName = (names, nameLenght) =>
{
  List<string> result = new List<string>();

    foreach (var currName in names)
    {
        if (currName.Length <= nameLenght )
        { 
            result.Add(currName);
        }
        
    }

    return result;
};

names = foundName(names,nameLenght);

Print(names);

void Print(List<string> names)
{
    foreach (var currName in names)
    {
        Console.WriteLine(currName);
    }
}