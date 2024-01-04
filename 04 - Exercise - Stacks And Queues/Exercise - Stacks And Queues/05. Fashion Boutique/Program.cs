using System.Runtime.InteropServices;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {   //  1   1   1   1   1
            // 5 4 8 6 3 8 7 7 9
            // 16

           int[] clothesInBox = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
           int clothes = int.Parse(Console.ReadLine());

            Stack<int> boxes = new Stack<int>(clothesInBox);

            int counterBox = 1;
            int sumInBox = 0;
            while (boxes.Any())
            {
                int currBox = boxes.Peek();
                sumInBox += currBox;
                if (sumInBox <= clothes)
                {
                    boxes.Pop();
                }
                else
                { 
                  counterBox++;
                  sumInBox = 0;
                }
            }
            Console.WriteLine(counterBox);
        }
    }
}