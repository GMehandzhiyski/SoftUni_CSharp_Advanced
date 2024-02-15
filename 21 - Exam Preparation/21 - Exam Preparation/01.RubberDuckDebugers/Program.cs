namespace _01.RubberDuckDebugers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] timeInput = Console.ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToArray();
            int[] taskInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> times = new Queue<int>(timeInput);
            Stack<int> tasks = new Stack<int>(taskInput);

            int darthVaderDucky = 0;
            int thorDucky = 0;
            int bigBlueRubberDucky = 0;
            int smallYellowRubberDucky = 0;

            while (times.Any()
                   && tasks.Any())
            {
                int currTime = times.Dequeue();
                int currTask = tasks.Pop();
                int multiplaySum = currTask * currTime;
                



                if (multiplaySum >= 0 && 60 >= multiplaySum)
                {
                    darthVaderDucky++;
                }
                else if (multiplaySum >= 61 && 120 >= multiplaySum)
                {
                    thorDucky++;
                }
                else if (multiplaySum >= 121 && 180 >= multiplaySum)
                {
                    bigBlueRubberDucky++;
                }
                else if (multiplaySum >= 181 && 240 >= multiplaySum)
                {
                    smallYellowRubberDucky++;
                }
                else 
                {
                    currTask -= 2;
                    tasks.Push(currTask);
                    times.Enqueue(currTime);
                }
            }

            Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");
            Console.WriteLine($"Darth Vader Ducky: {darthVaderDucky}");
            Console.WriteLine($"Thor Ducky: {thorDucky}");
            Console.WriteLine($"Big Blue Rubber Ducky: {bigBlueRubberDucky}");
            Console.WriteLine($"Small Yellow Rubber Ducky: {smallYellowRubberDucky}");

        }
    }
}