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
    ;
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

    // to add rules for correct input

    persons.Add(name, new Dictionary<string, Dictionary<string, int>>());
    persons[name].Add(cource, new Dictionary<string, int>());
    persons[name][cource].Add(password, score);

}
