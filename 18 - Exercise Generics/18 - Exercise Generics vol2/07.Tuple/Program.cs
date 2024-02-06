using System.ComponentModel;

namespace GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] name = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] beer = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] number = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            CustomTuple<string, string> names = new($"{name[0]} {name[1]}", name[2]);

            CustomTuple<string, int> beers = new(beer[0], int.Parse(beer[1]));

            CustomTuple<double, double> numbers = new(double.Parse(number[0]), double.Parse(number[1]));

            Console.WriteLine(names);
            Console.WriteLine(beers);
            Console.WriteLine(numbers);
        }   
    }
}