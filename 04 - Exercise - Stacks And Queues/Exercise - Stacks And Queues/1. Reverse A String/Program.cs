namespace _1._Reverse_A_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            Stack<char> stackString = new Stack<char>(inputString);

            //foreach (char c in stackString)
            //{
            //    Console.Write(c);
            //}
            //Console.WriteLine();
            while (stackString.Any())
            {
                char reuslt = stackString.Pop();
                Console.Write(reuslt);
            }
            ;
        }
    }
}