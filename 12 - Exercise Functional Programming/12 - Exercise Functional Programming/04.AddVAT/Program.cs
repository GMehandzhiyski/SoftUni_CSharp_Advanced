
using System.Text;

//1.38, 2.56, 4.4

Func<string,double> parse = p => double.Parse(p);

double[] numbers = Console.ReadLine()
    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
    .Select(parse)
    .Select(n => n * 1.2)
    .ToArray();

foreach (var number in numbers)

{
    Console.WriteLine($"{number:f3}") ;
}

