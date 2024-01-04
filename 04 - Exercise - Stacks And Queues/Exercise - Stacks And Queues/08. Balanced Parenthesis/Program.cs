namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] inputChar = Console.ReadLine()
                .ToArray();

            Stack<char> symbolStack = new Stack<char>();

            for (int i = 0; i < inputChar.Length; i++)
            {
                char currSymbol = inputChar[i];
                if (currSymbol == '{'
                    || currSymbol == '('
                    || currSymbol == '[')
                {
                    symbolStack.Push(currSymbol);
                }
                else
                {
                    char currSymbolInStack = symbolStack.Peek();
                    if (currSymbolInStack == '{'
                        && currSymbol == '}')
                    {
                        symbolStack.Pop();
                    }
                    else if (currSymbolInStack == '('
                             && currSymbol == ')')
                    {
                        symbolStack.Pop();
                    }
                    else if (currSymbolInStack == '['
                             && currSymbol == ']')
                    {
                        symbolStack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }
            if (symbolStack.Count > 0)
            {
                Console.WriteLine("NO");
                return;
            }
            
            Console.WriteLine("YES");
        }
    }
}