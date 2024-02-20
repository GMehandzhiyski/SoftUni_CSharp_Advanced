namespace _04.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalLiters = 0.0;
            double sumDegrees = 0.0;
            double averageDegrees = 0.0;


            for (int i = 0; i < days; i++)
            {
                double quantityRakia = double.Parse(Console.ReadLine());
                double degreesRakia = double.Parse(Console.ReadLine());

                totalLiters += quantityRakia;
                sumDegrees +=(quantityRakia * degreesRakia);
            }
            averageDegrees = (sumDegrees / totalLiters);

            Console.WriteLine($"Liter: {totalLiters:f2}");
            Console.WriteLine($"Degrees: {(averageDegrees):f2}");

            if (averageDegrees >= 38
                && averageDegrees <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if (averageDegrees < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (averageDegrees > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}