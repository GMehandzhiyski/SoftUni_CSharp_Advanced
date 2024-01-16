namespace _01.Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<double> inputString = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            Dictionary<double, int> valueInArray = new Dictionary<double, int>();

            foreach (var currSymbol in inputString)
            {
                if (!valueInArray.ContainsKey(currSymbol))
                {
                    valueInArray.Add(currSymbol, 0);
                }
                valueInArray[currSymbol]++; 
            }
            ;

            foreach (var currSymbol in valueInArray)
            {
                Console.WriteLine($"{currSymbol.Key} - {currSymbol.Value} times");
            }
        }
    }
}