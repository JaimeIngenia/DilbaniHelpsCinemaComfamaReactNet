using Microsoft.Data.SqlClient.Server;

namespace CinemaComfamav4React.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        //public int IdGenero { get; set; }
        //public int IdFormato { get; set; }
        public string Titulo { get; set; }
        public string ImagenPromocional { get; set; }
        public int Duracion { get; set; }
        public float Valor { get; set; }
        public string Sinopsis { get; set; }

        //Relaciones

        public int GeneroId { get; set; }
        public Genero Genero { get; set; }
        public int FormatoId { get; set; }
        public Formato Formato { get; set; }

        //Constructor

        public Pelicula(int idGenero,
            int idFormato,
            string titulo,
            string imagenPromocional,
            int duracion,
            float valor,
            string sinopsis)
        {
            GeneroId = idGenero;
            FormatoId = idFormato;
            Titulo = titulo;
            ImagenPromocional = imagenPromocional;
            Duracion = duracion;
            Valor = valor;
            Sinopsis = sinopsis;

        }

        private Pelicula()
        {
        }
    }
}
