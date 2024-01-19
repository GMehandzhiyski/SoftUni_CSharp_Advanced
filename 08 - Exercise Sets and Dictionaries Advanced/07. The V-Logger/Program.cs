

/*
EmilConrad joined The V-Logger
VenomTheDoctor joined The V-Logger
Saffrona joined The V-Logger
Saffrona joined The V-Logger
Saffrona followed EmilConrad 
Saffrona followed VenomTheDoctor
EmilConrad followed VenomTheDoctor
VenomTheDoctor followed VenomTheDoctor
Saffrona followed EmilConrad
Statistics
*/
using System.Collections.Generic;
using System.Drawing;

Dictionary<string, Dictionary<string, SortedSet<string>>> persons = new();

string arguments = string.Empty;
while ((arguments = Console.ReadLine()) != "Statistics")
{
    string[] commands = arguments
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string command = commands[1];
    string firstName = commands[0]; ;
    if (command == "joined")// последва
    {
        if (!persons.ContainsKey(firstName))
        {
            persons.Add(firstName, new Dictionary<string, SortedSet<string>>());
            persons[firstName].Add("followers", new SortedSet<string>());//последователи
            persons[firstName].Add("following", new SortedSet<string>());//следва

        }
    }
    else if (command == "followed")
    {
        string secondName = commands[2];
        bool isNamesAvalivable = CheckName(persons, firstName, secondName);
        if (isNamesAvalivable
            && !persons[firstName]["following"].Contains(secondName))
        {
            persons[secondName]["followers"].Add(firstName);
            persons[firstName]["following"].Add(secondName);
        }
    }
    else
    {
        continue;
    }
   
}
PrintResult(persons);

void PrintResult(Dictionary<string, Dictionary<string, SortedSet<string>>> persons)
{
   int number = 0;
   int countVlogger = persons.Count;
    Console.WriteLine($"The V-Logger has a total of {countVlogger} vloggers in its logs.");
    foreach (var currVlogger in persons.OrderByDescending(p => p.Value["followers"].Count).ThenBy(p => p.Value["following"].Count))
    {
        number++;
        Console.WriteLine($"{number}. {currVlogger.Key} : {currVlogger.Value["followers"].Count} followers, {currVlogger.Value["following"].Count} following");
        if (number == 1)
        {
            foreach (var follow in currVlogger.Value["followers"])
            {
                Console.WriteLine($"* {follow}");
            }
        }
    }
}

bool CheckName(Dictionary<string, Dictionary<string, SortedSet<string>>> person, string firstName, string secondName)
{
    return
        person.ContainsKey(firstName)
        && person.ContainsKey(secondName)
        && firstName != secondName;
}