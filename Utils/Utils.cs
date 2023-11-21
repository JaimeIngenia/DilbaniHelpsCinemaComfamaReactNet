using CinemaComfamav4React.Models;
using CinemaComfamav4React.Repositorios;

namespace CinemaComfamav4React.Utils
{
    public class Utils
    {
        public List<Pelicula> getPeliculas()
        {
            using var db = new CinemaContext();

            return db.Peliculas.ToList();
        }
        public List<Formato> getFormatos()
        {
            using var db = new CinemaContext();

            return db.Formatos.ToList();
        }

        public List<Genero> getGeneros()
        {
            using var db = new CinemaContext();

            return db.Generos.ToList();
        }

    }
}
