
using System.Globalization;

List<int> range = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
int startRange = range[0];
int endRange = range[1];    

string type = Console.ReadLine();
List<int> numbers = new List<int>();

// create range
Func<int,int, List<int>> createList = (startRangee, endRange) =>
{
     
    for (int i = startRangee; i <= endRange; i++)
    {
        numbers.Add(i);
    }
    return numbers;
};

// found odd or Even
Func<List<int>, string, List<int>> oddEvenList = (numbers, type) =>
{
    List<int> currList = new List<int>();

    if (type == "odd")
    {
        foreach (var currNumber in numbers)
        {
            if (currNumber % 2 != 0)
            { 
                currList.Add(currNumber);
            }
        }
    }
    else if (type == "even")
    {
        foreach (var currNumber in numbers)
        {
            if (currNumber % 2 == 0)
            {
                currList.Add(currNumber);
            }
        }
    }
    else 
    {
        return default;
    }

    return currList;
};


numbers = createList(startRange, endRange);
numbers = oddEvenList(numbers, type);

Console.WriteLine(string.Join(" ",numbers));
