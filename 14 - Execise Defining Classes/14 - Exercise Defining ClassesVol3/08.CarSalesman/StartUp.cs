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
            List<Engine> engines = new ();
            List<Car> cars = new();
            int numberEngines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberEngines; i++)
            {
                string[] token = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = token[0];
                string power = token[1];
                string displacement = "n/a";
                string efficiency = "n/a";

                if (token.Length == 3
                    && (token[2].Any(char.IsDigit)))
                {
                    displacement = token[2];
                }
                else if (token.Length == 3
                    && (token[2].Any(char.IsLetter)))
                {
                    efficiency = token[2];
                }
                else if (token.Length == 4)
                {
                    displacement = token[2];
                    efficiency = token[3];
                }

                Engine engine = new Engine(model, int.Parse(power), displacement, efficiency);
                if (!engines.Contains(engine))
                {
                    engines.Add(engine);
                }
                 
            }

            int numberCar = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberCar; i++)
            {
                string[] token = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = token[0];
                string engineIn = token[1];
                string weight = "n/a";
                string color = "n/a";

                if (token.Length == 3
                    && (token[2].Any(char.IsDigit)))
                {
                    weight = token[2];
                }
                else if (token.Length == 3
                    && (token[2].Any(char.IsLetter)))
                {
                    color = token[2];
                }
                else if (token.Length == 4)
                {
                    weight = token[2];
                    color = token[3];
                }

                Car car = new Car(model, engineIn, weight, color);
                if (!cars.Contains(car))
                {
                    cars.Add(car);
                }
                
            }

            foreach (var currCar in cars)
            {
                Console.WriteLine($"{currCar.Model}:");
                Console.WriteLine($"  {currCar.Engine}:");

                Engine engine = engines
                                .Where(e => e.Model == currCar.Engine).FirstOrDefault();

                Console.WriteLine($"    Power: {engine.Power}");
                Console.WriteLine($"    Displacement: {engine.Displacement}");
                Console.WriteLine($"    Efficiency: {engine.Efficiency}");
                Console.WriteLine($"  Weight: {currCar.Weight}");
                Console.WriteLine($"  Color: {currCar.Color}");

            }
        }
    }
}

