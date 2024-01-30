int number = int.Parse(Console.ReadLine());

HashSet<int> inputDivider = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToHashSet();   

List<int> finalList = new List<int>();
Func<int, List<int>> createList = number =>
                    Enumerable.Range(1,number).ToList();


Func<List<int>, HashSet<int>, List<int>> foundNumbers = (finalList, inputDivider) =>
{
    //foreach (var currNumber in finalList)
    //{
        
    //    foreach (var currDivider in inputDivider)
    //    {
    //        //if (currNumber % currDivider != 0)
    //        //{
    //        //    finalList.Remove(currNumber);
    //        //    break;
    //        //}
           
    //    }
    //}

    finalList = finalList.Where(currNumber =>
                   inputDivider.All(currDivider => currNumber % currDivider == 0)).ToList();

    return finalList;
};

finalList = createList(number);
finalList = foundNumbers(finalList, inputDivider);
Console.WriteLine(string.Join(" ", finalList));