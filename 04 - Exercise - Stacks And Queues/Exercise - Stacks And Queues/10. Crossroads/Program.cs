namespace _10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLineSecond = int.Parse(Console.ReadLine());
            int freeWindowSecond = int.Parse(Console.ReadLine());

            Queue<string> carJam = new Queue<string>();

            int passedCars = 0;

            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "END")
            {
                if (arguments == "green")
                {
                    int currGreenWindow = greenLineSecond;
                    int currFreeWindow = freeWindowSecond;

                    while (carJam.Any()
                           && currGreenWindow > 0)
                    {
                        string currCar = carJam.Dequeue();

                        if (currCar.Length <= currGreenWindow)
                        {
                            passedCars++;
                            currGreenWindow = (currGreenWindow - currCar.Length);
                            continue;
                        }
                        if (currCar.Length <= currGreenWindow + currFreeWindow
                            && currGreenWindow > 0)
                        {
                            passedCars++;
                            currGreenWindow = 0;
                            break;
                        }
                        if (currGreenWindow > 0
                            && currFreeWindow == freeWindowSecond)
                        {
                            char currLetter = currCar[currGreenWindow + currFreeWindow];
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{currCar} was hit at {currLetter}.");
                            return;

                        }

                    }
                }
                else
                {
                    carJam.Enqueue(arguments);
                }

            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
    }
}