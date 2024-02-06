namespace GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string item = Console.ReadLine();

                items.Add(item);
            }

            int[] token = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

           items =  SwapList(items, token[0], token[1]);

            PrintResult(items);
        }
        private static List<T> SwapList<T>(List<T> items, int token1, int token2)
        {
            (items[token1], items[token2]) = (items[token2], items[token1]);

            return items;
        }

        private static void PrintResult<T>(List<T> items)
        {

            foreach (var item in items)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
    }
}