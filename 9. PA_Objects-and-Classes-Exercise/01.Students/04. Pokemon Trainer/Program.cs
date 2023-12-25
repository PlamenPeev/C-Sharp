namespace _04._Pokemon_Trainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"

            string input = Console.ReadLine();

            List<Trainer> trainers = new List<Trainer>();

            while (input != "Tournament")
            {
                string[] data = input.Split(" ").ToArray();
                string trainerName = data[0];
                string pokemonName = data[1];
                string pokemonElement = data[2];
                int pokemonHealth = int.Parse(data[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);


                bool trainerExists = false;
                Trainer existingTrainer = new Trainer();

                foreach (Trainer trainer in trainers)
                {
                    if (trainerName == trainer.Name)
                    {
                        trainerExists = true;
                        existingTrainer = trainer;
                    }

                }


                if (trainerExists)
                {
                    existingTrainer.Pokemons.Add(pokemon);
                }
                else
                {
                    Trainer currentTr = new Trainer(trainerName);
                    currentTr.Pokemons.Add(pokemon);
                    trainers.Add(currentTr);
                }


                input = Console.ReadLine();
            }


            string command = Console.ReadLine();

            while (command != "End")
            {
                if(command != "Fire" && command != "Water" && command != "Electricity")
                {
                    command = Console.ReadLine();
                    break;
                }
                for (int i = 0; i < trainers.Count; i++)
                {
                    //trainers[i].Pokemons.RemoveAll(p => p.Health <= 0);

                    //foreach (Pokemon pokemon in trainers[i].Pokemons)
                    //{

                    //    if (command == pokemon.Element)
                    //    {
                    //        trainers[i].NumberOfBadges++;
                    //        break;
                    //    }
                    //    else
                    //    {
                    //        trainers[i].Pokemons.ForEach(p => p.Health -= 10);

                    //    }

                    //}



                    bool hasPokemon = false;
                    foreach (Pokemon pokemon in trainers[i].Pokemons)
                    {
                        if (command == pokemon.Element)
                            hasPokemon = true;
                    }

                    if (hasPokemon)
                    {
                        trainers[i].NumberOfBadges++;
                    }  
                    else
                    {
                        trainers[i].Pokemons.ForEach(p => { p.Health -= 10; });
                    }
                    trainers[i].Pokemons.RemoveAll(p => p.Health <= 0);



                }
                command = Console.ReadLine();
            }

            List<Trainer> sortedList = trainers.OrderByDescending(t => t.NumberOfBadges).ToList();
            foreach (Trainer t in sortedList)
            {
                Console.WriteLine($"{t.Name} {t.NumberOfBadges} {t.Pokemons.Count}");
            }


        }
    }
}