using PokemonMVC.Models;
using System;
using System.Linq;

namespace PokemonMVC.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PokemonContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Pokemons.
            if (context.Pokemons.Any())
            {
                return;   // DB has been seeded
            }

            var pokemons = new Pokemon[]
            {
                new Pokemon{Species="Tentacool", Type=PokemonType.Water},
                new Pokemon{Species="Psyduck", Type=PokemonType.Water},
                new Pokemon{Species="Geodude", Type=PokemonType.Rock},
                new Pokemon{Species="Mewtwo", Type=PokemonType.Psychic},
                new Pokemon{Species="Farfetch'd", Type=PokemonType.Flying}
            };
            foreach (Pokemon s in pokemons)
            {
                context.Pokemons.Add(s);
            }
            context.SaveChanges();

            var trainers = new Trainer[]
            {
            new Trainer{Name="Ash"},
            new Trainer{Name="Big Greg"},
            new Trainer{Name="Sally Johnson"},
            new Trainer{Name="Christine Thompson"},
            new Trainer{Name="Beefy Pete"},
            new Trainer{Name="Team Rocket Grunt"},
            new Trainer{Name="That Annoying Kid"}

            };
            foreach (Trainer c in trainers)
            {
                context.Trainers.Add(c);
            }
            context.SaveChanges();

            var catches = new Catch[]
            {
            new Catch{PokemonID=1, TrainerID=2, Nickname="Terry"},
            new Catch{PokemonID=2, TrainerID=2, Nickname="Dinner"},
            new Catch{PokemonID=3, TrainerID=1, Nickname="Rocky"},
            new Catch{PokemonID=4, TrainerID=3, Nickname="Cat O' Nine Tails"},
            new Catch{PokemonID=5, TrainerID=4, Nickname="Terry 2"}
            };
            foreach (Catch e in catches)
            {
                context.Catches.Add(e);
            }
            context.SaveChanges();
        }
    }
}