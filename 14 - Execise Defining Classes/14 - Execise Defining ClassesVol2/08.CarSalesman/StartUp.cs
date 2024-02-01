using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new();
            List<Car> cars = new();

            int numberEngines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberEngines; i++)
            {
                string[] engineIn = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = engineIn[0];
                int power = int.Parse(engineIn[1]);
                string displacement = "n/a";
                string efficiency = "n/a";
                bool containsNonDigits;

                if (engineIn.Length == 3
                    && (containsNonDigits = engineIn[2].Any(ch => !char.IsDigit(ch))))
                {
                    efficiency = engineIn[2];
                }
                else if (engineIn.Length == 3)
                {
                    displacement = engineIn[2];
                }
                else if (engineIn.Length == 4)
                {
                    displacement = engineIn[2];
                    efficiency = engineIn[3];
                }

                Engine engine = new Engine(model, power, displacement, efficiency);
                engines.Add(engine);
            }

            int numberCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberCars; i++)
            {
                string[] carIn = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carIn[0];
                string engine = carIn[1];
                string weight = "n/a";
                string color = "n/a";
                bool containsNonDigits;

                if (carIn.Length == 3
                    && (containsNonDigits = carIn[2].Any(ch => !char.IsDigit(ch))))
                {
                    color = carIn[2];
                }
                else if (carIn.Length == 3)
                {
                    weight = carIn[2];
                }
                else if(carIn.Length == 4)
                {
                    weight = carIn[2];
                    color = carIn[3];
                }

                Car car = new Car(model, engine, weight, color);
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine}:");
                foreach (var engine in engines)
                {
                    if (engine.Model == car.Engine)
                    {
                        //Console.WriteLine($"    {engine.Model}");
                        Console.WriteLine($"    Power: {engine.Power}");
                        Console.WriteLine($"    Displacement: {engine.Displacement}");    
                        Console.WriteLine($"    Efficiency: {engine.Efficiency}");
                    }
                }
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }

    }
}
