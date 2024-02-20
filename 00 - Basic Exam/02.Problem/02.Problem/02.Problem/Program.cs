namespace _02.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            int message = int.Parse(Console.ReadLine());
            int rosse = int.Parse(Console.ReadLine());
            int keychain = int.Parse(Console.ReadLine());
            int pictures = int.Parse(Console.ReadLine());
            int supprice = int.Parse(Console.ReadLine());


            double articulPrice = (message * 0.6) + (rosse * 7.20) + (keychain * 3.6) + (pictures * 18.20) + (supprice * 22);

            int totalArticul = message + rosse + keychain + pictures + supprice;
            double discaunt35ArticulPrice = 0.0;
            double finalPrice = 0.0;
            if (totalArticul > 25)
            {
              
                discaunt35ArticulPrice = articulPrice - (articulPrice * (35.0 / 100));
            }
            else 
            {
                discaunt35ArticulPrice = articulPrice;
            }

            finalPrice = discaunt35ArticulPrice - (discaunt35ArticulPrice *(10.0 / 100));


            if (finalPrice > price)
            {
                Console.WriteLine($"Yes! {(finalPrice - price):f2} lv left.");
            }
            else 
            {
                Console.WriteLine($"Not enough money! {Math.Abs(price - finalPrice):f2} lv needed.");
            }
        }

    }
}