
using System.Text;
string intputString = Console.ReadLine();
char[] inputChar = intputString.ToCharArray();   

Stack<int> stack = new Stack<int>();

for (int i = 0; i < inputChar.Length; i++)
{
    if (inputChar[i] == '(')
    {
        stack.Push(i);
    }

    if (inputChar[i] == ')')
    {
        int startIndex = (stack.Pop());

        StringBuilder sb = new StringBuilder();
        for (int j = startIndex; j < i +1; j++)
        {
            sb.Append(inputChar[j]);
        }
        Console.WriteLine(sb);
    }

}