using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmeApi.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> opts) : base(opts)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source=Filmes.db");
        }

        public DbSet<Filme> Filmes { get; set; }
    }
}