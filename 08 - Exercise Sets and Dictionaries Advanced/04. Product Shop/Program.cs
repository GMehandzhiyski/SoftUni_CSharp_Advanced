namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();


            string argoment = string.Empty; 
            while ((argoment = Console.ReadLine()) != "Revision") 
            {
                string[] commands = argoment
                   .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();

                string shop = commands[0];
                string product = commands[1];
                double price = double.Parse(commands[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());  
                }

                if (!shops[shop].ContainsKey(product))
                {
                    shops[shop].Add(product, price);
                }

                shops[shop][product] = price;
            }
             shops = shops.OrderBy(x => x.Key)
                .ToDictionary(x=>x.Key, x=>x.Value);

            Console.WriteLine();

            foreach (var currShop in shops)
            {
                Console.WriteLine($"{currShop.Key}->");

                foreach (var currProduct in currShop.Value)
                {
                    Console.Write($"Product: {currProduct.Key}, ");
                    Console.Write($"Price: {currProduct.Value}");
                    Console.WriteLine();
                }
            }


        }
    }
}