using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonMVC.Models
{
    public class Trainer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Catch> Catches { get; set; }
    }
}
