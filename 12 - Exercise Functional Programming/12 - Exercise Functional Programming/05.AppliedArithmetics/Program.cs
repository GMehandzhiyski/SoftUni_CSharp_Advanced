
using System.Security.Cryptography.X509Certificates;

List<int> inputNumbers = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

string arguments = string.Empty;
while ((arguments = Console.ReadLine()) != "end")
{
    string command = arguments;

    Func<List<int>, string, List<int>> listManipulator = (inputNumbers, command) =>
    {
       /// List<int> result = new List<int>();

        switch (command)
        {
            case "add":
                return inputNumbers.Select(x => x + 1).ToList();
                break;
            case "multiply":
                return inputNumbers.Select(x => x * 2).ToList();
                break;

            case "subtract":
                return inputNumbers.Select(x => x - 1).ToList();
                break;
            case "print":
                Console.WriteLine(string.Join(" ", inputNumbers));
                break;
        }
        return inputNumbers;
    };

    inputNumbers =  listManipulator (inputNumbers, arguments);  
}