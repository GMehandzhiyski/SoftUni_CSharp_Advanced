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

    string name = token[2];
    string cource = token[0];
    string password = token[1];
    int score = int.Parse(token[3]);

    bool isCourceCorrect = CheckCource(trainings, cource);
    bool isPasswordCorrect = CheckPassword(trainings, password);
    //bool isCourceAndUserIsInclude = CkeckCourceAndUser(persons, name, cource);
    bool isNameIsInclude = CkeckUser(persons, name);
    bool isCourceIsInclude = CkeckCource(persons, password);
   

    if (isCourceCorrect
        && isPasswordCorrect)
    {
        if (false)
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

bool CkeckCource(SortedDictionary<string, Dictionary<string, Dictionary<string, int>>> persons,string password)
{
    string matchingEntries = persons
             .Where(n => n.Value.Any(c => c.Value.ContainsKey(password)))
             .ToString();
 
    return true;
}

bool CkeckUser(SortedDictionary<string, Dictionary<string, Dictionary<string, int>>> persons, string name)
{
    return
    persons.ContainsKey(name);
}


//bool CkeckCourceAndUser(SortedDictionary<string, Dictionary<string, Dictionary<string, int>>> persons, string name, string cource)
//{
//    //var currPassword = trainings.Where(p => p.Key == name)
//    //                       .Select(p => p.Value)
//    //                       .Where(d => d.ContainsKey(cource))
//    //                       .Select(d => d[cource]);
//    //return false;
//    return true;
//}
bool CheckPassword(Dictionary<string, string> trainings, string password)
{
    return
        trainings.ContainsValue(password);
}
//bool CheckPassword(SortedDictionary<string, Dictionary<string, Dictionary<string, int>>> trainings, string name, string cource, string password)
//{
//    //foreach (var name in persons)
//    //{
//    //    foreach (var cource in name.Value)
//    //    {
//    //        foreach (var pass in cource.Key)
//    //        {
//    //            if (pass == password)///////////deibbbaaaaaa
//    //            {
//    //                return true;
//    //            }
//    //        }
//    //    }
//    //}
//    var currPassword = trainings.Where(p => p.Key == name)
//                           .Select(p => p.Value)
//                           .Where(d => d.ContainsKey(cource))
//                           .Select(d => d[cource])
//                           .Where(td => td.ContainsKey(password))
//                           .Select(td => td[password]);
//    return false;
//}

bool CheckCource(Dictionary<string, string> trainings, string cource)
{
    return
         trainings.ContainsKey(cource);
}

//SortedDictionary<string, Dictionary<string, Dictionary<string, int>>> persons = new();
//                  name               cource             pass   score

int totalSum = persons.Sum(m => m.Value.Sum(p => p.Value.Sum(s => s.Value))); 
Console.WriteLine(totalSum);
