using System.Data;
using System.Reflection;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOperation = int.Parse(Console.ReadLine());

            string mainString = string.Empty;

            Stack<string> stateStack = new Stack<string>();

            for (int i = 0; i < numberOperation; i++)
            {
                string[] commmands = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

              
               
                string command = commmands[0];
                int command3Counter = 0;

                if (command == "1") // add sting
                {
                    stateStack.Push(mainString);
                    mainString += commmands[1];
                   
                }
                else if (command == "2") // delate last
                {
                    stateStack.Push(mainString);
                    int delNumber =int.Parse(commmands[1]);
                    int startIndex = (mainString.Length - delNumber) - 1;
                    if (startIndex < 0)
                    {
                        startIndex  = 0;    
                    }
                    mainString = mainString.Remove(startIndex, delNumber);  

                }
                else if (command == "3")  //Print 
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
                    mainString = stateStack.Pop();
                }
            }
        }
    }
}