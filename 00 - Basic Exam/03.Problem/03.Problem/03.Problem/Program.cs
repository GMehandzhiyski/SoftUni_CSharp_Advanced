namespace _03.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double totalPrice = 0.0;
            double finalPrice = 0.0;

            if (season == "spring")
            {
                if (people <= 5)
                {
                    finalPrice = people * 50;
                }

                else
                {
                    finalPrice = people * 48;
                }


            }

            else if (season == "summer")
            {
                if (people <= 5)
                {
                    totalPrice = people * 48.50;
                    finalPrice = totalPrice - (totalPrice  * (15.0 / 100.0));
                }

                else
                {
                    totalPrice = people * 45;
                    finalPrice = totalPrice - (totalPrice  * (15.0 / 100.0));
                }
            }

            else if (season == "autumn")
            {
                if (people <= 5)
                {
                    finalPrice = people * 60;
                }

                else
                {
                    finalPrice = people * 49.50;
                }
            }

            else if (season == "winter")
            {
                if (people <= 5)
                {
                    totalPrice = people * 86.00;
                    finalPrice = totalPrice + (totalPrice * (8.0 / 100.0));
                }

                else
                {
                    totalPrice = people * 85.00;
                    finalPrice = totalPrice + (totalPrice * (8.0 / 100.0));
                }
            }

            Console.WriteLine($"{finalPrice:f2} leva.");
        }
    }
}