using System.Security.Cryptography.X509Certificates;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputNumber = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Stack<string> numberStack = new Stack<string>(inputNumber.Reverse());
            string sing = string.Empty;
            int number = 0;

            int result = int.Parse(numberStack.Pop());

           while(numberStack.Any())
            {
            
                sing = numberStack.Pop();
                number = int.Parse(numberStack.Pop());

                if (sing == "+")
                {
                 result += number;
                }
                else if (sing == "-")
                {
                 result -= number;
                }
            }

            Console.WriteLine(result);
        }
    }
}