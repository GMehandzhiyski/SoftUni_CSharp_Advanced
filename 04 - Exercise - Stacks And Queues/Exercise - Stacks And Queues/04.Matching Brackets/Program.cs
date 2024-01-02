namespace _04.Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            Stack<int> braketStack = new Stack<int>();

            for (int i = 0; i < inputString.Length; i++)
           {
                if (inputString[i] == '(')
                {
                    braketStack.Push(i);
                }
                else if (inputString[i] == ')')
                {
                    int begin = braketStack.Pop();
                    for (int j = begin; j <= i; j++)
                    {
                        Console.Write(inputString[j]);
                    }
                    Console.WriteLine();
                }
                else 
                {
                    continue;
                }
                
            }
        }
    }
}