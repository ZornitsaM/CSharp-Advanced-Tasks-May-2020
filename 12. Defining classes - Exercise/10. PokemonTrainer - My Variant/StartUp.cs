using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._PokemonTrainer___My_Variant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            while (command!= "Tournament")
            {
                string[] commandInfo = command.Split();
                string trainerName = commandInfo[0];
                string pokemonName = commandInfo[1];
                string pokemonElement = commandInfo[2];
                int pokemonHealth = int.Parse(commandInfo[3]);

        
                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName));

                }

                Trainer currentTrainer = trainers[trainerName];
                Pokemon currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                currentTrainer.Pokemons.Add(currentPokemon);


                command = Console.ReadLine();

            }

            string commandTwo = Console.ReadLine();

            while (commandTwo!="End")
            {
                string element = commandTwo;

                foreach (var item in trainers)
                {

                    if (item.Value.Pokemons.Any(x=>x.Element==element))
                    {
                        item.Value.Badges++;


                    }

                    else
                    {
                        foreach (var item2 in item.Value.Pokemons)
                        {
                            item2.Health -= 10;

                        }

                        item.Value.Pokemons.RemoveAll(x => x.Health <= 0);

                    }
                }


                commandTwo = Console.ReadLine();
            }



            var final = trainers.OrderByDescending(x => x.Value.Badges).ToDictionary(x => x.Key, v => v.Value);

            foreach (var item in final)
            {
                Console.WriteLine($"{item.Key} {item.Value.Badges} {item.Value.Pokemons.Count}");
            }
            
        }
    }
}
