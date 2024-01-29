
using System.Net.Security;

List<string> inputNames = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .ToList();

Action<List<string>, string> collName = (inputNames, title) => 
                             inputNames.ForEach(name => Console.WriteLine($"{title} {name}"));
//{
//    //foreach (string name in inputNames)
//    //{
//    //    Console.WriteLine($"{title} {name}");
//    //}
//};

string title = "Sir";
collName(inputNames, title);