namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] inputChar = Console.ReadLine()
                .ToArray();

            Stack<char> symbolStack = new Stack<char>();

            foreach (var currSymbol in inputChar)
            {
                if (currSymbol == '{'
                    || currSymbol == '('
                    || currSymbol == '[')
                {
                    symbolStack.Push(currSymbol);
                    continue;
                }


                if (symbolStack.Count == 0)
                {
                    symbolStack.Push(currSymbol);
                    break;
                }

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

            }
            if (symbolStack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }


        }
    }
}