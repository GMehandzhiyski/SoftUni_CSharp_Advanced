/*
Part One Interview:success
Js Fundamentals:JSFundPass
C# Fundamentals:fundPass
Algorithms:fun
end of contests
C# Fundamentals=>fundPass=>Tanya=>350
Algorithms=>fun=>Tanya=>380
Part One
Interview=>success=>Nikola=>120
Java Basics
Exam=>JSFundPass=>Parker=>400
Part One Interview=>success=>Tanya=>220
OOP Advanced=>password123=>BaiIvan=>231
C# Fundamentals=>fundPass=>Tanya=>250
C# Fundamentals=>fundPass=>Nikola=>200
Js Fundamentals=>JSFundPass=>Tanya=>400
end of submissions
 */


using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.Linq;

Dictionary<string, string> trainings = new();
SortedDictionary<string, Dictionary<string, Dictionary<string,int>>> persons = new();
//               name               cource             pass   score

string arguments = string.Empty;
while ((arguments = Console.ReadLine()) != "end of contests")
{
    string[] token = arguments
        .Split(":", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string contest = token[0];
    string password = token[1];

    trainings.Add(contest, password);
}

while ((arguments = Console.ReadLine()) != "end of submissions")
{
    string[] token = arguments
       .Split("=>", StringSplitOptions.RemoveEmptyEntries)
       .ToArray();

    string cource = token[0];
    string password = token[1];
    string name = token[2];
    int score = int.Parse(token[3]);

    bool isCourceCorrect = CheckCource(persons, cource);
    bool isPasswordCorrect = CheckPassword(persons, password);
    bool isCourceAndUserIsInclude = CkeckCourceAndUser(persons, name, cource, password, score);

    if (isCourceCorrect
        && isPasswordCorrect)
    {
        if (true)
        {
            
        }
        else
        {
            persons.Add(name, new Dictionary<string, Dictionary<string, int>>());
            persons[name].Add(cource, new Dictionary<string, int>());
            persons[name][cource].Add(password, score);
        }
       
    }
    else
    {
        continue;
    }

   

}

bool CkeckCourceAndUser(SortedDictionary<string, Dictionary<string, Dictionary<string, int>>> persons, string name, string cource, string password)
{
    foreach (var namme in persons)
    {
        foreach (var courcce in namme.Value)
        {
            
        }
    }

    return true;
}

bool CheckPassword(SortedDictionary<string, Dictionary<string, Dictionary<string, int>>> persons, string password)
{
    foreach (var name in persons)
    {
        foreach (var cource in name.Value)
        {
            foreach (var pass in cource.Key)
            {
                if (pass == password)///////////deibbbaaaaaa
                {
                    return true;
                }
            }
        }
    }
    //var keyExists = persons.SelectMany(firstPair => firstPair.Value
    //                .SelectMany(secondPair => secondPair.Value
    //                .Select(thirdPair => thirdPair.Key)))
    //                .Any(key => key == thirdKey);
    return false;
}

bool CheckCource(SortedDictionary<string, Dictionary<string, Dictionary<string, int>>> persons, string cource)
{
    return
         persons.ContainsKey(cource);
}

//SortedDictionary<string, Dictionary<string, Dictionary<string, int>>> persons = new();
//                  name               cource             pass   score

int totalSum = persons.Sum(person => person.Value.Sum(detail => detail.Value.Sum(d => d.Value))); 
Console.WriteLine(totalSum);
