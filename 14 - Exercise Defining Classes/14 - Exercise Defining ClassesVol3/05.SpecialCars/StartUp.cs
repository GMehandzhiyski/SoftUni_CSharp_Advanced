using System;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            List <Tire[]> tiresList = new();
            List<Engine> enginesList = new();
            List<Car> carsList = new();
            string argumets = string.Empty;
            while ((argumets = Console.ReadLine()) != "No more tires")
            {
                AddTires(argumets, tiresList);

            }

            while ((argumets = Console.ReadLine()) != "Engines done")
            {

                AddEngines(argumets, enginesList);

            }

            while ((argumets = Console.ReadLine()) != "Show special")
            {

                AddCars(argumets, carsList,tiresList, enginesList);

            }

            Func <Car,bool> filter = c =>
                          c.Year >= 2017
                          && c.Engine.HorsePower >= 330
                          && c.Tires.Sum(t => t.Pressure) >= 9
                          && c.Tires.Sum(t => t.Pressure) <= 10;
 
         List<Car> specialCars = new List<Car>();
            foreach (Car car in carsList.Where(filter))
            {
                car.Drive(20);
                specialCars.Add(car);
            }

            foreach (Car car in specialCars)
            {
                Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}\nHorsePowers: {car.Engine.HorsePower}\nFuelQuantity: {car.FuelQuantity:f1}");
            }
        }



        private static void AddTires(string argumets, List<Tire[]> tiresList)
        {
            string[] inputInformation = inputArray(argumets);

            List<Tire> tireList = new List<Tire>();
            for (int i = 0; i < inputInformation.Length; i++)
            {
                int year = int.Parse(inputInformation[i]);
                double pressure = double.Parse(inputInformation[i + 1]);

                Tire tire = new Tire(year, pressure);
                tireList.Add(tire);

                i++;
            }

            tiresList.Add(tireList.ToArray());
        }

        private static void AddEngines(string argumets, List<Engine> enginesList)
        {
            string[] inputInformation = inputArray(argumets);

            int horsePower = int.Parse(inputInformation[0]);
            double cubicCapacity = double.Parse(inputInformation[1]);

            Engine engines = new Engine(horsePower, cubicCapacity);
            enginesList.Add(engines);
        }

        private static void AddCars(string argumets, List<Car> carsList, List<Tire[]>tiresList, List<Engine>enginesList)
        {
            string[] inputArray = argumets
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();

            string make = inputArray[0];
            string model = inputArray[1];
            int year = int.Parse(inputArray[2]);
            double fuelQuantity = double.Parse(inputArray[3]);
            double fuelConsumption = double.Parse(inputArray[4]);
            int engineIndex = int.Parse(inputArray[5]);
            int tiresIndex = int.Parse(inputArray[6]);


           Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, enginesList[engineIndex], tiresList[tiresIndex]);
           carsList.Add(car);

        }
        private static string[] inputArray(string argumetsIn)
        {
            string[] inputArray = argumetsIn
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

            return inputArray;
        }
    }
}
