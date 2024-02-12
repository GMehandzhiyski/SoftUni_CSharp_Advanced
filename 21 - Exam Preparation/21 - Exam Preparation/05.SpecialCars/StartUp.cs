namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tiresList = new List<Tire[] > ();
            List<Engine> engines = new List<Engine> ();
            List<Car> cars = new List<Car> ();
            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "No more tires")
            {
                AddTires(arguments, tiresList);

            }

            while ((arguments = Console.ReadLine()) != "Engines done")
            {
                string[] token = arguments
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int horsePower = int.Parse(token[0]);
                double cubicCapacity = double.Parse(token[1]);

                Engine engine = new Engine(horsePower, cubicCapacity);
                engines.Add(engine);
            }

            while ((arguments = Console.ReadLine()) != "Show special")
            {
                string[] token = arguments
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string make = token[0];
                string model = token[1];
                int year = int.Parse(token[2]);
                double fuelQuantity = double.Parse(token[3]);
                double fuelConsumption = double.Parse(token[4]);
                int engineIndex = int.Parse(token[5]);  
                int tiresIndex = int.Parse(token[6]);
                
                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tiresList[tiresIndex]);
                cars.Add(car);
            }

            foreach (var car in cars.Where(c => c.Year >= 2017
                          && c.Engine.HorsePower >= 330
                          && c.Tires.Sum(t => t.Pressure) >= 9
                          && c.Tires.Sum(t => t.Pressure) <= 10))
            {
                car.Drive(20);
                Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}\nHorsePowers: {car.Engine.HorsePower}\nFuelQuantity: {car.FuelQuantity}");
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
        private static string[] inputArray(string argumetsIn)
        {
            string[] inputArray = argumetsIn
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

            return inputArray;
        }
    }
}