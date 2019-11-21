using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonMVC.Models
{
    public class Catch
    {
        public int ID { get; set; }
        public int PokemonID { get; set; }
        public int TrainerID { get; set; }
        public string Nickname { get; set; }
        
        public Pokemon Pokemon { get; set; }
    }
}
