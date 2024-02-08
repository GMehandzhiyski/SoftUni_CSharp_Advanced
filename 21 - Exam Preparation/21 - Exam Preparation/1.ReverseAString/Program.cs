using System;
using System.Text;

//Stack<char> stack = new();

//string inputString = Console.ReadLine();

//foreach (var itemChar in inputString)
//{
//    stack.Push(itemChar);
//}
//StringBuilder sb = new StringBuilder();
//foreach (var chars in stack)
//{
//    sb.Append(chars);
//}

//Console.WriteLine(sb);\

Stack<char> stack = new();

string inputString = Console.ReadLine();

foreach (var itemChar in inputString)
{
    stack.Push(itemChar);
}

string finalString = string.Empty;
while (stack.Any())
{
   finalString += stack.Pop().ToString();
}

Console.WriteLine(finalString);