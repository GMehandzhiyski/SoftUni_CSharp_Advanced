namespace _06.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int firstLimit = int.Parse(Console.ReadLine());
            int secondLimit  = int.Parse(Console.ReadLine());
            int thirdLimits = int.Parse(Console.ReadLine());

   
            for (int i = 2; i <= firstLimit; i += 2) 
            {
                for (int j = 2; j <= secondLimit; j++)
                {
                    bool isDigitCorect = CheckDigit(j);
                    if (isDigitCorect) 
                    {
                        for (int k = 2; k <= thirdLimits; k += 2)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }

        static bool CheckDigit(int number)
        {
            if (number < 2)
            {
                return false;
            } 

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                } 
            }

            return true;
        }



    }
}