using CinemaComfamav4React.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaComfamav4React.Repositorios
{
    public class CinemaContext : DbContext
    {
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Formato> Formatos { get; set; }
        public DbSet<Genero> Generos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-NK1EERFF;Initial Catalog=CinemaComfamaReact;Integrated Security=True;Trust Server Certificate=true");
        }
    }
}
