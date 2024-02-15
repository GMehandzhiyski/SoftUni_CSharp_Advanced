using System.Text;

namespace _01.OffroadChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputFuel = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] inputConsumption = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] inputAumontFuel = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> fuel = new Stack<int>(inputFuel);
            Queue<int> consumption = new Queue<int>(inputConsumption);
            Queue<int> aumontFuel = new Queue<int>(inputAumontFuel);
            int altitudeCounter = 0;

            while (fuel.Any()
                    && consumption.Any())
            {
                int currFuel = fuel.Pop();
                int currConsumption = consumption.Dequeue();
                int currAumont = aumontFuel.Dequeue();
                int residue = currFuel - currConsumption;
                bool isFault = false;

                if (residue >= currAumont)
                {
                    altitudeCounter++;
                    Console.WriteLine($"John has reached: Altitude {altitudeCounter}");

                }

                else if (residue < currAumont)
                {
                    altitudeCounter++;
                    Console.WriteLine($"John did not reach: Altitude {altitudeCounter}");
                    isFault = true;
                }


                if (altitudeCounter > 1
                    && isFault)
                {
                    StringBuilder sb = new StringBuilder();
                    Console.WriteLine("John failed to reach the top.");
                    sb.Append("Reached altitudes: ");
                    for (int i = 1; i < altitudeCounter; i++)
                    {
                        sb.Append("Altitude " + i + ", ");
                    }
                    Console.WriteLine(sb.ToString().TrimEnd(',', ' '));

                    return;
                }

                else if (altitudeCounter == 1
                    && isFault)
                {
                    Console.WriteLine("John failed to reach the top.\nJohn didn't reach any altitude.");
                    return;
                }
            }
            Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
        }
    }
}