namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < number; i++)
            {
                names.Add(Console.ReadLine());  
            }

            foreach (var currName in names)
            {
                Console.WriteLine(currName);
            }
        }
    }
}