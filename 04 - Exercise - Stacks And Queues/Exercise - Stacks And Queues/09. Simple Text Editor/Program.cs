using System.Data;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOperation = int.Parse(Console.ReadLine());
            string mainString = string.Empty;

            for (int i = 0; i < numberOperation; i++)
            {
                string[] commmands = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                //Stack<string> textStack = new Stack<string>();
               
                string command = commmands[0];
                int command3Counter = 0;

                if (command == "1")
                {
                   mainString += commmands[1];
                }
                else if (command == "2")
                { 
                
                }
                else if (command == "3") 
                {
                    int numberOfChar = int.Parse(commmands[1]);
                    foreach (var currSymbol in mainString)
                    {
                        command3Counter++;
                        if (command3Counter == numberOfChar)
                        {
                            Console.WriteLine(currSymbol);
                            break;
                        }
                    }
                    command3Counter = 0;
                }
                else if (command == "4") 
                { 
                
                }
            }
        }
    }
}