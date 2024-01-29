
using System.Threading.Channels;

HashSet<int> inputNumbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToHashSet();

Func<HashSet<int>, int> finalNumber = numbers => 
                        numbers.FirstOrDefault(x => x == inputNumbers.Min());
//{
//    int sumOfNUmber = int.MaxValue;
//    foreach (var number in numbers)
//    {
//        if (number < sumOfNUmber)
//        {
//            sumOfNUmber = number;
//        }
//    }
    
//    return sumOfNUmber;
//};
int finNumber = 0;

Action<int> printNumber = number => Console.WriteLine(finNumber);

finNumber = finalNumber(inputNumbers);
printNumber(finNumber);
