
List<int> inputList = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

int divider = int.Parse(Console.ReadLine());

Predicate<int> checkNumbers = inputList =>
                    inputList % divider == 0;

Func<List<int>, Predicate<int>, List<int>> foundDivideNumber = (inputList, match) =>
{
    List<int> result = new List<int>();
    foreach (var currNumber in inputList)
    {
        if (!match(currNumber))
        {
            result.Add(currNumber);
        }
    }


    return result;
};


Func<List<int>, List<int>> reverceList = inputList =>
{
    List<int> result = new ();
    for (int i = inputList.Count - 1; i >= 0; i--)
    {
        result.Add(inputList[i]);
    }

    return result;
};

inputList = foundDivideNumber(inputList, checkNumbers);
inputList = reverceList(inputList);
Console.WriteLine(string.Join(" ", inputList));