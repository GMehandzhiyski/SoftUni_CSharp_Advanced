using System.ComponentModel;
using System.Xml;

namespace _12._Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputCup = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] inputBottles = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> bottles = new Stack<int>(inputBottles);
            Queue<int> cups = new Queue<int>(inputCup);

            int waterWaste = 0;
            while (bottles.Any()
                   && cups.Any())
            {

                int currBottle = bottles.Peek();
                int currCup = cups.Peek();

                if (currBottle >= currCup)
                {
                    waterWaste += currBottle - currCup;
                    bottles.Pop();
                    cups.Dequeue();
                }
                else
                {
                    int bottleAcu = 0;
                    while (true)
                    {
                        bottleAcu += bottles.Pop();
                        if (bottleAcu >= currCup)
                        {
                            waterWaste += bottleAcu - currCup;
                            break;
                        }
                    }
                    cups.Dequeue();
                }
            }

            if (cups.Count == 0)
            {
                string finalString = string.Empty;
                foreach (var currBottles in bottles)
                {
                    finalString += currBottles + " ";
                }
                Console.WriteLine($"Bottles: {finalString}");
                Console.WriteLine($"Wasted litters of water: {waterWaste}");
            }
            if (bottles.Count == 0)
            {
                string finalString = string.Empty;
                foreach (var currCup in cups)
                {
                    finalString += currCup + " ";
                }
                Console.WriteLine($"Cups: {finalString + " "}");
                Console.WriteLine($"Wasted litters of water: {waterWaste}");
            }
        }
    }
}