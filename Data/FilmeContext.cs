using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmeApi.Data
{
    public class FilmeContext : DbContext
    {
        public DbSet<Filme> Filmes { get; set; }

        public FilmeContext(DbContextOptions<FilmeContext> opts) : base(opts)
        {

        }
    }
}