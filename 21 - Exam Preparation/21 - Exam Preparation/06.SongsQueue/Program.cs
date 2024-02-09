

using System.Security.Cryptography.X509Certificates;

string[] inputSongs = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

Queue<string> songs = new Queue<string>(inputSongs);  

while (songs.Any())
{
    string[] commands = Console.ReadLine()
         .Split(" ", StringSplitOptions.RemoveEmptyEntries);

   string command = commands[0];

    if (command == "Play")
    {
        songs.Dequeue();
    }
    else if (command == "Add")
    {
        string songName = string.Join(" ", commands[1..]);
        bool isSongAvalivable = CheckSoung(songs, songName);
        if (!isSongAvalivable)
        {
            songs.Enqueue(songName);
        }
        else
        {
            Console.WriteLine($"{songName} is already contained!");
        }

    }
    else if (command == "Show") 
    {
        PrintAllSongs(songs);
    }

}

void PrintAllSongs(Queue<string> songs)
{
    string finalSongs = string.Empty;
    foreach (var currSong in songs)
    {
        finalSongs += currSong + ", "; 
    }
    Console.WriteLine(finalSongs.TrimEnd(',',' '));
}

bool CheckSoung(Queue<string> songs, string songName)
{
    bool currName;
   return currName = songs.Contains(songName);
}

Console.WriteLine("No more songs!");