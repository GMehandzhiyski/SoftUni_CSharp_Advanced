namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cyclesOperation = int.Parse(Console.ReadLine());
            int cyclesCount = 0;

            Stack<int> numbers = new Stack<int>();

            while (cyclesOperation > cyclesCount)
            {
                string[] commands = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int firstCommand = int.Parse(commands[0]);
                int numberForPush = 0;
                if (commands.Length > 1)
                {
                    numberForPush = int.Parse(commands[1]);
                }


                int currNumberHigh = int.MinValue;
                int currNumberLow = int.MaxValue;

                if (firstCommand == 1)
                {
                    numbers.Push(numberForPush);
                }
                else if (firstCommand == 2)
                {
                    numbers.Pop();
                }
                else if (firstCommand == 3
                        && numbers.Any())// Max Value
                {

                    foreach (var currNumber in numbers)
                    {
                        if (currNumberHigh < currNumber)
                        {
                            currNumberHigh = currNumber;
                        }

                    }

                    Console.WriteLine(currNumberHigh);
                }
                else if (firstCommand == 4
                         && numbers.Any())// Min Value
                {
                    foreach (var currNumber in numbers)
                    {
                        if (currNumberLow > currNumber)
                        {
                            currNumberLow = currNumber;
                        }
                    }

                    Console.WriteLine(currNumberLow);
                }

                cyclesCount++;
            }

            string finalResult = string.Empty;
            foreach (int currNumber in numbers)
            {
                finalResult += currNumber.ToString() + ", ";
            }

            Console.WriteLine(finalResult.TrimEnd(',', ' '));
        }
    }
}