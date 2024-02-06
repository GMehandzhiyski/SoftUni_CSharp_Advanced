using System.ComponentModel;

namespace GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            for (int i = 0; i < number; i++)
            {
                double item = double.Parse(Console.ReadLine());

                box.Add(item);
            }

            double element = double.Parse(Console.ReadLine());
            box.Copmare(element);
            Console.WriteLine(box.Count);    
        }   
    }
}