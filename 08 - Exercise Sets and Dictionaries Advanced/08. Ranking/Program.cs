/*
Part One Interview:success
Js Fundamentals:JSFundPass
C# Fundamentals:fundPass
Algorithms:fun
end of contests
C# Fundamentals=>fundPass=>Tanya=>350
Algorithms=>fun=>Tanya=>380
Part One Interview=>success=>Nikola=>120
Java Basics
Exam=>JSFundPass=>Parker=>400
Part One Interview=>success=>Tanya=>220
OOP Advanced=>password123=>BaiIvan=>231
C# Fundamentals=>fundPass=>Tanya=>250
C# Fundamentals=>fundPass=>Nikola=>200
Js Fundamentals=>JSFundPass=>Tanya=>400
end of submissions

Java Advanced:funpass
Part Two Interview:success
Math Concept:asdasd
Java Web Basics:forrF
end of contests
Math Concept=>ispass=>Monika=>290
Java Advanced=>funpass=>Simon=>400 
Part Two Interview=>success=>Drago=>120
Java Advanced=>funpass=>Petyr=>90 
Java Web Basics=>forrF=>Simon=>280
Part Two Interview=>success=>Petyr=>0
Math Concept=>asdasd=>Drago=>250
Part Two Interview=>success=>Simon=>200
end of submissions
 */


using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.Linq;

Dictionary<string, string> trainings = new();
SortedDictionary<string, SortedDictionary<string, int>> persons = new();
//               name             cource  score

string arguments = string.Empty;
while ((arguments = Console.ReadLine()) != "end of contests")
{
    string[] token = arguments
        .Split(":", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    if (token.Length < 2
        && token.Length > 3)
    {
        continue;
    }

    string contest = token[0];
    string password = token[1];

    trainings.Add(contest, password);
}

while ((arguments = Console.ReadLine()) != "end of submissions")
{
    string[] token = arguments
       .Split("=>", StringSplitOptions.RemoveEmptyEntries)
       .ToArray();
    if (token.Length < 4
        && token.Length > 4)
    {
        continue;
    }
    string name = token[2];
    string cource = token[0];
    string password = token[1];
    int score = int.Parse(token[3]);

    bool isCourceCorrect = CheckCource(trainings, cource);
    bool isPasswordCorrect = CheckPassword(trainings, password);

    if (isCourceCorrect
        && isPasswordCorrect)
    {
        bool isNameIsInclude = CkeckUser(persons, name);
        bool isCourceIsInclude = CkeckCource(persons, name, cource);

        if (!isNameIsInclude)
        {
            persons[name] = new SortedDictionary<string, int>();
            //persons[name].Add(cource, score);
        }
        if (!isCourceIsInclude)
        {
            persons[name][cource] = score;
        }
        if (score > persons[name][cource])
        {
            persons[name][cource] = score;
        }


        //else if (isNameIsInclude
        //    && isCourceIsInclude)
        //{
        //    var currscore = persons[name][cource];
        //    if (currscore <= score)
        //    {
        //        persons[name][cource] = currscore;
        //    }
        //}

    }
    else
    {
        continue;

    }
}
PrintBestCandidate(persons);
PirntRanking(persons);

void PirntRanking(SortedDictionary<string, SortedDictionary<string, int>> persons)
{
    Console.WriteLine("Ranking:");
    foreach (var currPerson in persons.OrderBy(x => x.Key))
    {
        Console.WriteLine(currPerson.Key);
        foreach (var currInfo in currPerson.Value.OrderByDescending(c => c.Value))
        {
            Console.WriteLine($"#  {currInfo.Key} -> {currInfo.Value}");
        }
    }
}

void PrintBestCandidate(SortedDictionary<string, SortedDictionary<string, int>> persons)
{
    //int higgestScore = 0;
    //string bestUser = string.Empty;

    //foreach (var user in persons)
    //{
    //    int currentMaxPoints = 0;
    //    foreach (var data in user.Value)
    //    {
    //        currentMaxPoints += data.Value;
    //    }
    //    if (currentMaxPoints > higgestScore)
    //    {
    //        higgestScore = currentMaxPoints;
    //        bestUser = user.Key;
    //    }
    //}
    //Console.WriteLine($"Best candidate is {bestUser} with total {higgestScore} points.");
    var topCandidate = persons.OrderByDescending(persons => persons.Value.Sum(cource => cource.Value)).First();
    Console.WriteLine($"Best candidate is {topCandidate.Key} with total {topCandidate.Value.Sum(sum => sum.Value)} points.");
}

bool CkeckCource(SortedDictionary<string, SortedDictionary<string, int>> persons, string name, string cource)
{
    var currPerson = false;
    var currCource = false;
    currPerson = persons.ContainsKey(name);
    if (currPerson)
    {
        return currCource = persons[name].ContainsKey(cource);
    }

    return false;
}

bool CkeckUser(SortedDictionary<string, SortedDictionary<string, int>> persons, string name)
{
    return
    persons.ContainsKey(name);
}

bool CheckPassword(Dictionary<string, string> trainings, string password)
{
    return
        trainings.ContainsValue(password);
}


bool CheckCource(Dictionary<string, string> trainings, string cource)
{
    return
         trainings.ContainsKey(cource);
}





