using System.Reflection.Metadata.Ecma335;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new HashSet<string>();

            string argumets = string.Empty;
            while ((argumets = Console.ReadLine()) != "END")
            {
                string[] commands = argumets
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = commands[0];
                string carNumber = commands[1];

                if (command == "IN")
                {
                    parkingLot.Add(carNumber);
                }

                if (command == "OUT")
                {
                    parkingLot.Remove(carNumber);
                }

            }

            if (parkingLot.Count <= 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            } 

            foreach (var currCar in parkingLot)
            {
                Console.WriteLine(currCar);
            }
        }
    }
}