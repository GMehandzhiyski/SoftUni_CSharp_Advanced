
//using System.ComponentModel.Design;

//int numberPump = int.Parse(Console.ReadLine());
//Queue<(int, int)> pumpes = new();

//for (int i = 0; i < numberPump; i++)
//{
//    string[] inputPumps = Console.ReadLine()
//        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

//    pumpes.Enqueue((int.Parse(inputPumps[0]), int.Parse(inputPumps[1])));
//}
//int counterPump = 0;
//while (true) 
//{
//    foreach ((int,int) pump in pumpes)
//    {
//        if (pump.Item1 < pump.Item2)
//        {
//            counterPump++;
//        }
//        else 
//        {
//            Console.WriteLine(counterPump);
//            return;
//        }

//    }
//}

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
            int bestRoute = 0;
            while (true)
            {
                int petrol = 0;
                foreach ((int, int) pump in pumps)
                {
                    petrol += pump.Item1;
                    int distance = pump.Item2;
                    if (petrol - distance < 0)
                    {
                        petrol = -1;
                        break;
                    }
                    else
                    {
                        petrol -= distance;
                    }
                }
                if (petrol >= 0)
                {
                    break;
                }
                bestRoute++;
                pumps.Enqueue(pumps.Dequeue());


            }

            Console.WriteLine(bestRoute);
        }
    }
}