using System.Diagnostics.Metrics;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputPlayers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

            int hotPottato = int.Parse(Console.ReadLine());

            Queue<string> playersQueue = new Queue<string>(inputPlayers);

            int cycleCounter = 1;
            while (playersQueue.Count > 1)
            {
                if (hotPottato == 1)
                {
                    string removeHotPottato = playersQueue.Dequeue();
                    Console.WriteLine($"Removed {removeHotPottato}");

                }
                else 
                { 
                  playersQueue.Enqueue(playersQueue.Dequeue());
                cycleCounter++;
                if (cycleCounter == hotPottato)
                {
                    string removeHotPottato = playersQueue.Dequeue();
                    Console.WriteLine($"Removed {removeHotPottato}");
                    cycleCounter = 1;
                }
                }
              

            }

            string finalPlayer = playersQueue.Peek();
            Console.WriteLine($"Last is {finalPlayer}");
        }
    }
}