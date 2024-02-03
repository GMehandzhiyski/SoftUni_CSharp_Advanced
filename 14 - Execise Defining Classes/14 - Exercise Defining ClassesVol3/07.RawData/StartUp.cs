using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int numberCar = int.Parse(Console.ReadLine());
            List<Car> cars = new();

            for (int i = 0; i < numberCar; i++)
            {
                string[] token = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = token[0];
                int engineSpeed = int.Parse(token[1]);
                int enginePower = int.Parse(token[2]);
                int cargoWeight = int.Parse(token[3]);
                string cargoType = token[4];
                double tire1Pressure = double.Parse(token[5]);
                int tire1Age = int.Parse(token[6]);
                double tire2Pressure = double.Parse(token[7]);
                int tire2Age = int.Parse(token[8]);
                double tire3Pressure = double.Parse(token[9]);
                int tire3Age = int.Parse(token[10]);
                double tire4Pressure = double.Parse(token[11]);
                int tire4Age = int.Parse(token[12]);

                Car car = new Car(model,
                                    engineSpeed,
                                    enginePower,
                                    cargoWeight,
                                    cargoType,
                                    tire1Pressure,
                                    tire1Age,
                                    tire2Pressure,
                                    tire2Age,
                                     tire3Pressure,
                                    tire3Age,
                                    tire4Pressure,
                                     tire4Age);
                cars.Add(car);
            }
            string command = Console.ReadLine();

            if (command == "fragile")
            {
                string fragile = "fragile";

                Car[] currCar = cars
                    .Where(c => c.Cargo.Type == fragile
                    && c.Tires.Any(p => p.Pressure < 1))
                    .ToArray();

                PrintCar(currCar);
            }
            if (command == "flammable")
            {
                string flammable = "flammable";

                Car[] currCar = cars
                    .Where(c => c.Cargo.Type == flammable
                    && c.Engine.Power > 250)
                    .ToArray();

                PrintCar(currCar);
            }
        }

        private static void PrintCar(Car[] currCar)
        {
            foreach (var car in currCar)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}

