﻿namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
           Car car = new Car();
            car.Make = "Vw";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200000;
            car.FuelConsumption = 20;
            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());

        }
    }
}
