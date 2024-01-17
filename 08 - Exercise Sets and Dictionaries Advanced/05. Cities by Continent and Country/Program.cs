using System.Diagnostics;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < number; i++)
            {
                string[] inputString = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string continent = inputString[0];
                string country = inputString[1];
                string town = inputString[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country, new List<string>());
                }

                
                continents[continent][country].Add(town);

            }

            foreach (var continent in continents)
            {

                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.Write($"  {country.Key} -> ");
                    string finalTown = string.Empty;
                    foreach (var town in country.Value)
                    {
                        finalTown += town + ", ";
                    }
                    Console.Write($"{finalTown.TrimEnd(',', ' ')}");
                    Console.WriteLine();
                }
            }
        }
    }
}