using System.Text;

namespace _01.WormsAndHoles
{
   public class Program
    {
        static void Main(string[] args)
        {


            
            int[] inputWorms =  Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] inputHoles = Console.ReadLine()
              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToArray();

            Stack<int> worms = new Stack<int>(inputWorms);
            Queue<int> holes = new Queue<int>(inputHoles);

            int matches = 0;
            int noneWorms = 0;
            bool wormsNotFit = false;

            while (worms.Count > 0
                && holes.Count > 0) 
            {
              int currWormValue = worms.Pop();
              int currHoleValue = holes.Dequeue();

                if (currWormValue == currHoleValue)
                {
                    matches++;
                }
                else 
                {   
                    wormsNotFit |= true;
                    currWormValue -= 3;
                    if (currWormValue > 0) 
                    {
                        worms.Push(currWormValue);
                    }
                    
                }
            
            
            }

            // first line
            if (matches > 0)
            {
                Console.WriteLine($"Matches: {matches}");
            }
            else
            {
                Console.WriteLine("There are no matches.");
            }


            // second line
            if (worms.Count == 0
                && !wormsNotFit)
            {
                Console.WriteLine("Every worm found a suitable hole!");

            }
            else if (wormsNotFit
                    && worms.Count == 0)
            {
                Console.WriteLine("Worms left: none");
            }
            else
            {
                StringBuilder sb = new StringBuilder();

                foreach (var worm in worms)
                {
                    sb.Append(worm + ", ");
                }
                Console.WriteLine($"Worms left: {sb.ToString().TrimEnd(',', ' ')}");
            }


            // third line
            if (!holes.Any())
            {
                Console.WriteLine("Holes left: none");
            }
            else
            {
                StringBuilder sb = new StringBuilder();

                foreach (var hole in holes)
                {
                    sb.Append(hole + ", ");
                }
                Console.WriteLine($"Holes left: {sb.ToString().TrimEnd(',', ' ')}");
            }

        }
    }
}