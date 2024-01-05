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
                    int leftTime = 0;
                    int currGreenWindow = greenLineSecond;
                    int currFreeWindow = freeWindowSecond;
                    while (carJam.Any())
                    {
                        string currCar = carJam.Dequeue();
                        //int greenLinePassTime = currCar.Length - greenLineSecond;

                        if (currCar.Length < currGreenWindow)
                        {
                            passedCars++;
                            currGreenWindow = (greenLineSecond - currCar.Length);
                            continue;
                        }
                        if (currCar.Length < currGreenWindow + currFreeWindow
                            && currGreenWindow > 0)
                        {
                            passedCars++;
                            currGreenWindow = 0;
                            break;
                        }
                        if (currGreenWindow > 0
                            && currFreeWindow == freeWindowSecond)
                        {
                            //int currLetterIndex = currGreenWindow + currFreeWindow;
                            //int counterCycle = 0;
                            //char currLetter = '\0';
                            //foreach (var currLet in currCar)
                            //{
                            //    counterCycle++;
                            //    if (currLetterIndex + 1 == counterCycle)
                            //    {
                            //        currLetter = currLet;
                            //    }
                            //}
                            char currLetter = currCar[currGreenWindow + currFreeWindow];
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{currCar} was hit at {currLetter}.");
                            return;

                        }
                        if (currGreenWindow < currCar.Length)
                        {
                            continue;
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