namespace CinemaComfamav4React.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string NombreGenero { get; set; }

        public ICollection<Pelicula> Peliculas { get; set; } = new List<Pelicula>();

        public Genero(string nombreGenero)
        {
            NombreGenero = nombreGenero;
        }
    }
}
