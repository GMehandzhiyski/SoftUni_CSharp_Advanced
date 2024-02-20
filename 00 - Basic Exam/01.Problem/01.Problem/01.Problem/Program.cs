namespace _01.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fat = int.Parse(Console.ReadLine());
            double prot = int.Parse(Console.ReadLine());
            double carbon = int.Parse(Console.ReadLine());
            double totalCal = int.Parse(Console.ReadLine());
            double water = int.Parse(Console.ReadLine());

            
            double totalFat = ((fat / 100) * totalCal) / 9;
            double totalProt = ((prot / 100) * totalCal) / 4;
            double totalarbon = ((carbon / 100) * totalCal) / 4;

            double foodTotal  = totalFat + totalProt + totalarbon;

            double calPerGram = totalCal / foodTotal;
            double calRusult =  calPerGram * ((100 - water)/100 );

            Console.WriteLine($"{calRusult:f4}");
        }
    }
}