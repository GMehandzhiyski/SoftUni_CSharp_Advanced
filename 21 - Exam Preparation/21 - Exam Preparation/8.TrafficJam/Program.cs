
Queue<string> queueTrafic = new();   

int n = int.Parse(Console.ReadLine());
string arguments = string.Empty;
int passedCouter = 0;
while ((arguments = Console.ReadLine()) != "end")
{
    if (arguments == "green")
    {
        for (int i = 0; i < n && queueTrafic.Any(); i++)
        {
            Console.WriteLine($"{queueTrafic.Dequeue()} passed!");
            passedCouter++;
        }

        continue;
    }
    
    queueTrafic.Enqueue(arguments);
}

Console.WriteLine($"{passedCouter} cars passed the crossroads.");