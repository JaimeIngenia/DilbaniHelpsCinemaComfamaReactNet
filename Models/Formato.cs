namespace CinemaComfamav4React.Models
{
    public class Formato
    {
        public int Id { get; set; }
        public string NombreFormato { get; set; }

        public ICollection<Pelicula> Peliculas { get; set; } = new List<Pelicula>();

        public Formato(string nombreFormato)
        {
            NombreFormato = nombreFormato;
        }
    }
}
