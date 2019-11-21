using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonMVC.Models
{
    public enum PokemonType
    {
        Water, Rock, Psychic, Flying
    }

    public class Pokemon
    {
        public int ID { get; set; }
        public string Species { get; set; }
        public PokemonType Type { get; set; }
    }
}
