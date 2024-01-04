namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int number of pump
            // petrol(L) distance(km)

            int numberOfPump = int.Parse(Console.ReadLine());

            Queue<(int, int)> pumps = new Queue<(int, int)>();

            for (int i = 0; i < numberOfPump; i++)
            {
                int[] pumpsInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                

                int petrol = pumpsInput[0];
                int distance = pumpsInput[1];

                pumps.Enqueue((petrol, distance));
            }

            while (true)
            {
                foreach (var pump in pumps)
                {
                    int petrol = pump.Item1;
                    int distance = pump.Item2;
                    if (petrol - distance < 0)
                    {

                    }
                    else
                    { 
                    
                    }
                }

            }

            ;
        }
    }
}