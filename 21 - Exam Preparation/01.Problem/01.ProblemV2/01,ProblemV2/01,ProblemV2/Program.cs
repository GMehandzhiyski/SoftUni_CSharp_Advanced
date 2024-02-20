namespace _01.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] moneyInput = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            int[] foodInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            Stack<int> money = new Stack<int>(moneyInput);
            Queue<int> food = new Queue<int>(foodInput);
            int eatingFood = 0;
            while (money.Any()
                   && food.Any())
            {
                int currMoney = money.Pop();
                int currFood = food.Dequeue();

                if (currMoney == currFood)
                {
                    eatingFood++;
                }
                if (currMoney > currFood)
                {
                    int ostSum = currMoney - currFood;
                    int nextMoney = 0;
                    if (money.Any())
                    {
                        nextMoney = money.Pop();
                    }
                    money.Push(ostSum + nextMoney);
                    eatingFood++;
                }
            }

            if (eatingFood >= 4)
            {
                Console.WriteLine($"Gluttony of the day! Henry ate {eatingFood} foods.");
            }
            if (eatingFood <4
                && eatingFood > 1)
            {
                Console.WriteLine($"Henry ate: {eatingFood} foods.");
            }
            if (eatingFood == 1)
            {
                Console.WriteLine($"Henry ate: {eatingFood} food.");
            }
            if (eatingFood <= 0)
            {
                Console.WriteLine($"Henry remained hungry. He will try next weekend again.");
            }

        }
    }
}