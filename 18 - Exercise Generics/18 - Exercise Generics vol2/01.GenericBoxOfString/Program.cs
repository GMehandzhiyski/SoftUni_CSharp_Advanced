namespace GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < number; i++)
            {
                string item = Console.ReadLine();

                  

                box.Add(item);
            }

            Console.WriteLine(box.ToString());
        }
    }
}