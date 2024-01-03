namespace _08._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passOnGreen = int.Parse(Console.ReadLine());

            Queue<string> carQueue = new Queue<string>();
            int cycleToPass = 0;
            string argumets = string.Empty;
            int cycleCarPass = 0;
            while ((argumets = Console.ReadLine()) != "end")
      {
                if (argumets == "green")
                {
                    while (cycleToPass > 0
                        && carQueue.Any())
                    {
                        string carPass = carQueue.Dequeue();
                        Console.WriteLine($"{carPass} car passed!");
                        cycleToPass--;
                        cycleCarPass++;
                    }
                }
                else
                {
                    carQueue.Enqueue(argumets);
                }
                 cycleToPass = passOnGreen;
            }

            Console.WriteLine($"{cycleCarPass} cars passed the crossroads.");
        }
    }
}