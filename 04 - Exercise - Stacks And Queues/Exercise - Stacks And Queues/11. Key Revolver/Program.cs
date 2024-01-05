namespace _11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] locks = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int intelligence = int.Parse(Console.ReadLine());

            Queue<int> locksQueue = new Queue<int>(locks);

            Stack<int> bulletsStack = new Stack<int>(bullets);

            int reloadingCounter = 0;
            int firebulletsCount = 0; 
            while (locksQueue.Any()
                    && bulletsStack.Any()) 
            {
                int currBullets = bulletsStack.Pop();
                int currLocker = locksQueue.Peek();

                if (reloadingCounter == gunBarrel)
                {
                    Console.WriteLine("Reloading!");
                    reloadingCounter = 0;
                }

                if (currBullets <= currLocker)
                {
                    Console.WriteLine("Bang!");
                    locksQueue.Dequeue();
                    reloadingCounter++;
                    firebulletsCount++;
                }
                else
                {
                    Console.WriteLine("Ping!");
                    reloadingCounter++;
                    firebulletsCount++;
                }

                if (reloadingCounter == gunBarrel
                    && bulletsStack.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    reloadingCounter = 0;
                }

            }

            if (bulletsStack.Count == 0
                && locksQueue.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
                return;
            }
           else
            {
                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${intelligence - (firebulletsCount * bulletPrice)}");
            }

        }
    }
}