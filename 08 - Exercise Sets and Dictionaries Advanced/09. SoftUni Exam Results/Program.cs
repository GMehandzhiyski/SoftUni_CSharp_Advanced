/*
Peter-Java-84
George-C#-70
George-C#-84
Sam-C#-94
exam finished

Peter-Java-91
George-C#-84
Sam-JavaScript-90
Sam-C#-50
Sam-banned
exam finished
 */

SortedDictionary<string, decimal> students = new();
SortedDictionary<string, int> submissions = new();

string arguments = string.Empty;
while ((arguments = Console.ReadLine()) != "exam finished")
{
    string[] token = arguments
        .Split("-", StringSplitOptions.RemoveEmptyEntries);

    string userName = token[0];
    string language = token[1];


    if (language == "banned")
    {
        students.Remove(userName);
        continue;
    }

    decimal points = decimal.Parse(token[2]);
    if (!students.ContainsKey(userName))
    {
        students.Add(userName, points);
    }
    else if (students.ContainsKey(userName))
    {
        if (points > students[userName]) 
        {
            students[userName] = points;
        }
    }

    if (!submissions.ContainsKey(language))
    {
        submissions.Add(language, 1);
    }
    else
    {
        submissions[language]++;
    }

}
PintResultStudents(students);
PRintResultLanguage(submissions);

void PRintResultLanguage(SortedDictionary<string, int> submissions)
{
    Console.WriteLine("Submissions:");
    foreach (var currLan in submissions.OrderByDescending(l => l.Value))
    {
        Console.WriteLine($"{currLan.Key} - {currLan.Value}");
    }
}

void PintResultStudents(SortedDictionary<string, decimal> students)
{
    Console.WriteLine("Results:");
    foreach (var currStudent in students.OrderByDescending(p => p.Value))
    {
        Console.WriteLine($"{currStudent.Key} | {currStudent.Value} ");
    }
}