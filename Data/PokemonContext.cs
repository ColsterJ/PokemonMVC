using PokemonMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace PokemonMVC.Data
{
    public class PokemonContext : DbContext
    {
        public PokemonContext(DbContextOptions<PokemonContext> options) : base(options)
        {
        }

        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Catch> Catches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trainer>().ToTable("Trainer");
            modelBuilder.Entity<Pokemon>().ToTable("Pokemon");
            modelBuilder.Entity<Catch>().ToTable("Catch");
        }
    }
}