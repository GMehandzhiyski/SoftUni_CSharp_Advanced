namespace _05.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> players = new Dictionary<string,int>();  
            string token = string.Empty; 
            while ((token = Console.ReadLine()) != "END")
            {
                int goals = int.Parse(Console.ReadLine());
                if (!players.ContainsKey(token))
                {
                    players.Add(token, goals);
                }
                if (goals >= 10)
                {
                    break;
                }
            }

            var currPlayer = players.OrderByDescending(p => p.Value).FirstOrDefault();

            Console.WriteLine($"{currPlayer.Key} is the best player!");
            if (currPlayer.Value > 2)
            {
                Console.WriteLine($"He has scored {currPlayer.Value} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {currPlayer.Value} goals.");
            }
        }
    }
}