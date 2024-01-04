namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> ordersQueue = new Queue<int>(orders);

            int biggestOrder = int.MinValue;
            foreach (var currOrder in ordersQueue)
            {
                if (biggestOrder < currOrder)
                { 
                    biggestOrder = currOrder;
                }
            }
            Console.WriteLine(biggestOrder);

            while (ordersQueue.Any())
            {
                int orderComplete = ordersQueue.Dequeue();
                if (orderComplete > quantityFood)
                {
                    Console.WriteLine($"Orders left: {orderComplete}");
                    return;
                }
                quantityFood -= orderComplete;
                
            }
            Console.WriteLine("Orders complete");
        }
    }
}