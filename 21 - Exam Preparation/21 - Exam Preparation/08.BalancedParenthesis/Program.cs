
string inputParent = Console.ReadLine();

Stack<char> holderPatent = new();


while (true)
{
   foreach (var newSymbol in inputParent)
    {
       // string newSymbol = ;
        bool isCorrectSymbol = CheckSymbol(newSymbol);
        if (isCorrectSymbol
            || holderPatent.Count == 0)
        {
            holderPatent.Push(newSymbol);
        }
        else 
        {
            char currSymbol = holderPatent.Peek();

            bool isNewSymboIsCorrect = CheckNewSymbol(currSymbol, newSymbol);

            if (isNewSymboIsCorrect)
            {
                holderPatent.Pop();
            }
            //else
            //{
            //    Console.WriteLine("NO");
            //    return;
            //}
        }
    }

    if (holderPatent.Count == 0)
    {
        Console.WriteLine("YES");
    }
    else 
    {
        Console.WriteLine("NO");
    }
   
    return;
}

bool CheckSymbol(char newSymbol)
{
    return (newSymbol == '(')
            || (newSymbol == '{')
            || (newSymbol == '[');
}

bool CheckNewSymbol(char currSymbol, char newSymbol)
{
    return (currSymbol == '('
            && newSymbol == ')')
     || (currSymbol == '{'
            && newSymbol == '}')
     || (currSymbol == '['
            && newSymbol == ']');

}