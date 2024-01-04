using System.Security.Cryptography.X509Certificates;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> inputSongs = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Queue<string> allSongs =  new Queue<string>(inputSongs);

            while (allSongs.Any())
            {
                string[] commands = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string soungNameCreate = string.Empty;
                for (int i = 1; i < commands.Length; i++)
                {
                   soungNameCreate += commands[i] + " ";
                }

                string command = commands[0];

                if (command == "Play")
                {
                    allSongs.Dequeue();
                }
                else if (command == "Add")
                {
                    string soung = soungNameCreate.TrimEnd(' ');
                    bool isSongIsContained = CheckSong(allSongs, soung);

                    if (isSongIsContained) 
                    {
                        Console.WriteLine($"{soung} is already contained!");
                    }
                    else
                    {
                        allSongs.Enqueue(soung);
                    }

                }
                else if (command == "Show")
                {
                    PrintAllSoungs(allSongs);
                }
                
            }
            Console.WriteLine("No more songs!");

        }

        private static void PrintAllSoungs(Queue<string> allSongs)
        {
            string finalResult = string.Empty;
            foreach (var currSong in allSongs)
            {
                finalResult += currSong + ", ";
            }
            Console.WriteLine(finalResult.TrimEnd(',',' '));
        }

        private static bool CheckSong(Queue<string> allSongs, string soung)
        {
          bool  isSongIsContained = false;
            foreach (var currSoung in allSongs)
            {
                if (currSoung == soung) 
                {
                    isSongIsContained = true;
                    break;
                }
            }
            return isSongIsContained;
        }
    }
}