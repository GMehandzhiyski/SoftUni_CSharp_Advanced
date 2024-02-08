

string[] inputName = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
int potatoNumber = int.Parse(Console.ReadLine());

Queue<string> queueName = new Queue<string>(inputName);
int countRotation = 1;
while (queueName.Count != 1)
{
   while(countRotation < potatoNumber)
    {
        countRotation++;
        string name = queueName.Dequeue();
        queueName.Enqueue(name);
       
    }
    Console.WriteLine($"Removed {queueName.Dequeue()}");
    countRotation = 1;

}

Console.WriteLine($"Last is {queueName.Dequeue()}");