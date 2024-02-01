using System;
using System.ComponentModel;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            List<Tire> tiresList = new();
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

                AddCars(argumets, carsList);

            }

            
            //Tire[] tires =
            //{
            //    new Tire(1, 2.5),
            //    new Tire(1, 2.1),
            //    new Tire(2, 0.5),
            //    new Tire(2, 2.3),
            //};

            //var engine = new Engine(560, 6300);

            //var car = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);

            //Console.WriteLine(car.WhoAmI());
        }



        private static void AddTires(string argumets, List<Tire> tiresList)
        {
            string[] inputInformation = inputArray(argumets);

            for (int i = 0; i < inputInformation.Length; i++)
            {
                int year = int.Parse(inputInformation[i]);
                double pressure = double.Parse(inputInformation[i + 1]);

                Tire tire = new Tire(year, pressure);
                tiresList.Add(tire);
                i++;
            }
        }

        private static void AddEngines(string argumets, List<Engine> enginesList)
        {
            string[] inputInformation = inputArray(argumets);

            int horsePower = int.Parse(inputInformation[0]);
            double cubicCapacity = double.Parse(inputInformation[1]);

            Engine engines = new Engine(horsePower, cubicCapacity);
            enginesList.Add(engines);   
        }

        private static void AddCars(string argumets, List<Car>carsList)
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


            //Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, Engine [engineIndex] engine, tire[tiresIndex]);


            //var car = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);


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
