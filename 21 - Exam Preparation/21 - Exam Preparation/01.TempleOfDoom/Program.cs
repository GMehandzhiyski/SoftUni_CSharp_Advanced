using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _01.TempleOfDoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] toolsInput = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            int[] substancesInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] challengeInput = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            Queue<int> tools = new Queue<int>(toolsInput);
            Stack<int> substances = new Stack<int>(substancesInput);
            List<int> challenges = new List<int>(challengeInput);

            while (tools.Any()
                   && substances.Any()) 
            {
                int currTools = tools.Dequeue();
                int currSubstances = substances.Pop();
                int multiplayResult = currTools * currSubstances;

                int challengeIndex = 0;
                bool isFoudIndex = false;   
                for (int i = 0; i < challenges.Count; i++)
                {
                    if (challenges[i] == multiplayResult)
                    {
                        challengeIndex = i;
                        isFoudIndex = true;
                        break;
                        //moje da ima poveche ot edno chislo
                    }
                }

                if (isFoudIndex)
                {
                    challenges.RemoveAt(challengeIndex);
                }

                if (!challenges.Any())
                {
                    Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
                    PrintResults(tools,substances, challenges);
                    return;
                }


                if (!isFoudIndex)
                {
                    currTools += 1;
                    tools.Enqueue(currTools);

                    currSubstances -= 1;
                    if (currSubstances > 0) 
                    {
                        substances.Push(currSubstances);
                    }
                   
                }

            }
            Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
            PrintResults(tools, substances, challenges);


        }

        private static void PrintResults(Queue<int> tools, Stack<int> substances, List<int> challenges)
        {
            if (tools.Any())
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Tools: ");
                foreach (var tool in tools)
                {
                    sb.Append(tool.ToString() + ", ");
                }
                Console.WriteLine(sb.ToString().TrimEnd(',', ' '));

            }
            if (substances.Any())
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Substances: ");
                foreach (var substance in substances)
                {
                    sb.Append(substance.ToString() + ", ");
                }
                Console.WriteLine(sb.ToString().TrimEnd(',', ' '));
            }
            if (challenges.Any())
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Challenges: ");
                foreach (var challenge in challenges)
                {
                    sb.Append(challenge.ToString() + ", ");
                }
                Console.WriteLine(sb.ToString().TrimEnd(',', ' '));
            }
        }
    
    }
}