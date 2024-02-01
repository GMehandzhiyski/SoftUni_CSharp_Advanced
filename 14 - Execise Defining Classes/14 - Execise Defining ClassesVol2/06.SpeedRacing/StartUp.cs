using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        { 
            List<Car> cars = new ();
            int numberCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberCars; i++)
            {
                string[] inputCars = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = inputCars[0];
                int fuelAmount = int.Parse(inputCars[1]);
                double fuelConsumptionFor1km = double.Parse(inputCars[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km,0);
                if (!cars.Contains(car))
                {
                    cars.Add(car);
                }
            }
            string token = string.Empty;
            while ((token = Console.ReadLine()) != "End")
            {
                string[] commands = token
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = commands[0];
                string carModel = commands[1];
                int amountOfKm = int.Parse(commands[2]);

               

               Car carDriving = cars
                    .Where(x => x.Model == carModel)
                    .First();

                bool isCarMove;
                if (!(isCarMove = carDriving.MovingCar(amountOfKm)))
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
