using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class PokeapiContext : DbContext
    {
        public PokeapiContext(DbContextOptions<PokeapiContext> options)
            : base(options)
        {

        }

        public DbSet<Pokemonx> Pokemons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokemonx>().ToTable("Pokemonx");
        }

    }
}