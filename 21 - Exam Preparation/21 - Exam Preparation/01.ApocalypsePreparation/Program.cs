using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _01.ApocalypsePreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] textileInput = Console.ReadLine()
              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToArray();
            int[] medicamentsInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> textiles = new Queue<int>(textileInput);
            Stack<int> medicaments = new Stack<int>(medicamentsInput);
            SortedDictionary<string, int> colections = new SortedDictionary<string, int>();

            string patch = "Patch";
            string bandage = "Bandage";
            string medKit = "MedKit";
            string tool = string.Empty;
            while (medicaments.Any()
                    && textiles.Any())
            {
                int currTextiles = textiles.Dequeue();
                int currMedicamets = medicaments.Pop();

                int sum = currMedicamets + currTextiles;

                if (sum == 30)
                {
                    tool = patch;
                    addToColections(tool, colections);
                  
                }
                else if (sum == 40)
                {
                    tool = bandage;
                    addToColections(tool, colections);
                }
                else if (sum == 100)
                {
                    tool = medKit;
                    addToColections(tool, colections);
                }
                else if (sum > 100)
                {
                    tool = medKit;
                    addToColections(tool, colections);
                    int lastElement = medicaments.Pop();
                    medicaments.Push((sum - 100) + lastElement);
                }
                else
                {
                    currMedicamets += 10;
                    medicaments.Push(currMedicamets);
                }
            }

            if (!textiles.Any()
                && !medicaments.Any())
            {
                Console.WriteLine("Textiles and medicaments are both empty.");
            }
            else if (!textiles.Any())
            {
                Console.WriteLine("Textiles are empty.");
            }
            else if (!medicaments.Any())
            {
                Console.WriteLine("Medicaments are empty.");
            }

            if (colections.Any())
            {
                PrintColections(colections);
            }

            if (medicaments.Any())
            {
                PrintMedi(medicaments);
            }

            if (textiles.Any())
            {
                PrintText(textiles);
            }
        }

        private static void PrintText(Queue<int> textiles)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Textiles left: ");
            foreach (var textile in textiles)
            {
                sb.Append($"{textile}, ");
            }
            Console.WriteLine(sb.ToString().TrimEnd(',', ' '));
        }

        private static void PrintMedi(Stack<int> medicaments)
        {
            StringBuilder   sb = new StringBuilder();
           sb.Append("Textiles left: ");
            foreach (var medicament in medicaments)
            {
                sb.Append($"{medicament}, ");
            }
            Console.WriteLine(sb.ToString().TrimEnd(',',' '));
        }

        private static void PrintColections(SortedDictionary<string, int> colections)
        {
            foreach (var item in colections.OrderByDescending(c => c.Value))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }

        private static void addToColections(string tool, SortedDictionary<string, int> colections)
        {
            
            if (!colections.Keys.Contains(tool))
            {
                int value = 1;
                colections.Add(tool, value);
            }
            else
            {
                colections[tool] += 1;
            }
        }
    }
}