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
            List<Trainers> trainers = new();

            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "Tournament")
            {
                string[] token = arguments
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string trainerName = token[0];
                string pokemonName = token[1];
                string pokemonElements = token[2];
                int pokemonHealth = int.Parse(token[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElements, pokemonHealth);
                if (!trainers
                    .Any(t => t.Name == trainerName))
                {
                    Trainers trainer = new Trainers(trainerName);
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }
                else
                {
                    Trainers currTrainer = trainers
                           .Where(t => t.Name == trainerName).FirstOrDefault();
                    currTrainer.Pokemons.Add(pokemon);
                    //trainers.Add(currTrainer);
                }
            }

            while ((arguments = Console.ReadLine()) != "End")
            {
                if (!(arguments == "Fire"
                    || arguments == "Water"
                    || arguments == "Electricity"))
                {
                    continue;
                }
                foreach (var currTrainer in trainers)
                {
                    if (currTrainer.Pokemons
                        .Any(e => e.Element == arguments))
                    {
                        currTrainer.Bages += 1;
                    }
                    else
                    {
                        foreach (var currPokemons in currTrainer.Pokemons)
                        {
                            currPokemons.Health -= 10;
                        }

                        currTrainer.Pokemons.RemoveAll(h => h.Health <= 0);
                    }
                }
            }

            foreach (var currTrainers in trainers.OrderByDescending(b => b.Bages))
            {
                Console.WriteLine($"{currTrainers.Name} {currTrainers.Bages} {currTrainers.Pokemons.Count}");
            }
        }
    }
}

