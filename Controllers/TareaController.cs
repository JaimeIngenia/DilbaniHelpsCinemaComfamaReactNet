using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CinemaComfamav4React.Models;
using CinemaComfamav4React.Repositorios;

namespace CinemaComfamav4React.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        private readonly CinemaContext _dbcontext;

        public TareaController(CinemaContext context )
        {
            _dbcontext = context;
        }

        [HttpGet]
        [Route("Lista")]
        public async Task<IActionResult> Lista()
        {
            List<Genero> lista = _dbcontext.Generos.OrderByDescending( x => x.Id ).ToList();
            Console.WriteLine(lista);
            Console.WriteLine("texto");
            return StatusCode(StatusCodes.Status200OK, lista);
        }
        
    }
}
