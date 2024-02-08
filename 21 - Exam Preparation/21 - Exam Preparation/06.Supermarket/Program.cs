
Queue<string> queue = new Queue<string>();
string arguments = string.Empty; 
while ((arguments = Console.ReadLine()) != "End" )
{
    if (arguments == "Paid")
    {
        while (queue.Any())
        {
            Console.WriteLine(queue.Dequeue());
           
        }
        continue;
    }

    queue.Enqueue(arguments);
}
    Console.WriteLine($"{queue.Count} people remaining.");
