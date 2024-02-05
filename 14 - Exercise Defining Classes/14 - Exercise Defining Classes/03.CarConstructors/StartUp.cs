using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car car = new();
            //car.Make = "Vw";
            //car.Model = "Golf";
            //car.Year = 2025;
            //car.FuelQuantity = 200;
            //car.FuelConsumption = 10;
            //car.Drive(2000);
           
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
