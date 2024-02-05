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
            List<Trainers> trainerList = new(); 
            string argumet = string.Empty;
            while ((argumet = Console.ReadLine()) != "Tournament")
            {
                string[] tokens = argumet
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);

                Pokemon newPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainerList
                    .Any(t => t.Name == trainerName))
                {
                    Trainers trainers = new Trainers(trainerName);
                    trainers.Pokemons.Add(newPokemon);
                    trainerList.Add(trainers);
                }
                else 
                {
                    Trainers currTrainer = trainerList
                                           .Where(t => t.Name == trainerName).FirstOrDefault();
                    currTrainer.Pokemons.Add(newPokemon);
                }
            }

            while ((argumet = Console.ReadLine()) != "End")
            {
                string currElement = argumet;

                foreach (var currTrainer in trainerList)
                {
                    if (currTrainer.Pokemons
                                    .Any(p => p.Element == currElement))
                    {
                        currTrainer.Badges += 1;
                    }
                    else
                    {
                        foreach (var pokemon in currTrainer.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }

                        currTrainer.Pokemons.RemoveAll(p => p.Health <= 0);
                    }

                }
            }

            foreach (var currTrainer in trainerList.OrderByDescending(c => c.Badges))
            {
                Console.WriteLine($"{currTrainer.Name} {currTrainer.Badges} {currTrainer.Pokemons.Count}");
            }
        }

    }
