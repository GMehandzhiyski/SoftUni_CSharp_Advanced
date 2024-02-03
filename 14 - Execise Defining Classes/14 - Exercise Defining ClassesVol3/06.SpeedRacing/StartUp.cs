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
            List<Car> cars = new();
            int numberCar = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberCar; i++)
            {
                string[] carInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carInput[0];
                int fuelAmount = int.Parse(carInput[1]); 
                double fuelConsumptionFor1km = double.Parse(carInput[2]);

                Car car = new(model, fuelAmount, fuelConsumptionFor1km,0.0);
                if (!cars.Contains(car))
                {
                    cars.Add(car);
                }
               
            }
            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "End")
            {
                string[] carInput = arguments
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                
                    string command = carInput[0];
                    string model = carInput[1];
                    double amountOfKm = double.Parse(carInput[2]);

                Car carDriving = cars
                  .Where(x => x.Model == model)
                  .First();

                if (command == "Drive")
                {
                    carDriving.DriveCar(amountOfKm);
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}

