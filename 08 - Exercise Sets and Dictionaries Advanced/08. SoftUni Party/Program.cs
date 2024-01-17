namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vip = new HashSet<string>();  
            HashSet<string> regular = new HashSet<string>();
            

            string arguments = string.Empty;
            bool isPartyTime = false;
            while ((arguments = Console.ReadLine()) != "END")
            {
                bool isFirstCharDigit = CheckFirstChar(arguments);
               
                if (arguments == "PARTY")
                {
                    isPartyTime = true;

                }

                if (!isPartyTime)
                {
                    if (isFirstCharDigit)// VIP
                    {
                        vip.Add(arguments);
                    }
                    else                //Regular
                    {
                        regular.Add(arguments);
                    }
                }
                else 
                {
                    if (isFirstCharDigit)
                    {
                        vip.Remove(arguments);
                    }
                    else
                    {
                        regular.Remove(arguments);
                    }

                }

            }
            PrintProc(vip, regular);

        }

        private static void PrintProc(HashSet<string> vip, HashSet<string> regular)
        {
            Console.WriteLine(vip.Count + regular.Count);
            foreach (var currVip in vip)
            {
                Console.WriteLine(currVip);
            }
            foreach (var currRegular in regular)
            {
                Console.WriteLine(currRegular);
            }
        }

        private static bool CheckFirstChar(string arguments)
        {
            return Char.IsDigit(arguments[0]);
        }
    }
}