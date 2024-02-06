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

            CustomTuple<string, string, string> names = new($"{name[0]} {name[1]}", name[2], string.Join(" ",name[3..]));

            CustomTuple<string, int, bool> beers = new(beer[0], int.Parse(beer[1]), beer[2] == "drunk");

            CustomTuple<string, double, string> numbers = new((number[0]), double.Parse(number[1]), number[2]);

            Console.WriteLine(names);
            Console.WriteLine(beers);
            Console.WriteLine(numbers);
        }   
    }
}