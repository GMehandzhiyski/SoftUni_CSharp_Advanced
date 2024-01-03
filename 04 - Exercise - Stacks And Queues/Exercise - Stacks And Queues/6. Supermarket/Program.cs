namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> nameQueue = new Queue<string>();

            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "End")
            {
                if (arguments == "Paid")
                {
                    while (nameQueue.Any())
                    {
                        string printName = nameQueue.Dequeue();
                        Console.WriteLine(printName);
                    }
                  
                }
                else
                { 
                    nameQueue.Enqueue(arguments);
                }
            }

            Console.WriteLine($"{nameQueue.Count} people remaining.");

        }
    }
}