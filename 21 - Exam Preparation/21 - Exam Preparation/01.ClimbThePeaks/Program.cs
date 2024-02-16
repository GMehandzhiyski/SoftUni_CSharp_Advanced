namespace _01.ClimbThePeaks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] foodInput = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            int[] staminaInput = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> food = new Stack<int>(foodInput);
            Queue<int> stamina = new Queue<int>(staminaInput);
            Dictionary<int, string> peeks = new Dictionary<int, string>()
            {
                {80,"Vihren"},
                {90,"Kutelo"},
                {100,"Banski Suhodol"},
                {60,"Polezhan"},
                {70,"Kamenitza"},
            };
            List<string> climbingPeeks = new List<string>();
            int days = 0;
            while (days < 8
                    && food.Any()
                    && stamina.Any()
                    && peeks.Any())
            {
                int currFood = food.Pop();
                int currStamina = stamina.Dequeue();

                int sum = currFood + currStamina;
                
                if (sum >= peeks.Keys.FirstOrDefault()) 
                { 
                    string peek = peeks.Values.FirstOrDefault().ToString();
                    climbingPeeks.Add(peek);
                    peeks.Remove(peeks.Keys.FirstOrDefault());
                }
                days++;

            }
            if (!peeks.Any())
            {
                Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
            }
            else
            {
                Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
            }

            if (climbingPeeks.Any())
            {
                Console.WriteLine("Conquered peaks:");
                foreach (var peek in climbingPeeks)
                {
                    Console.WriteLine(peek);
                }
            }
        }
    }
}