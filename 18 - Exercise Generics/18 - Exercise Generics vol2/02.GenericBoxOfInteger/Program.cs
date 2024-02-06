namespace GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();

            for (int i = 0; i < number; i++)
            {
                int item = int.Parse(Console.ReadLine());

                  

                box.Add(item);
            }

            Console.WriteLine(box.ToString());
        }   
    }
}