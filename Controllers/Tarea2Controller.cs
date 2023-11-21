using CinemaComfamav4React.Models;
using CinemaComfamav4React.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaComfamav4React.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tarea2Controller : ControllerBase
    {
        private readonly CinemaContext _dbcontext;

        public Tarea2Controller()
        {
            _dbcontext = new CinemaContext();
        }

        [HttpGet]
        [Route("Lista")]
        public async Task<IActionResult> Lista()
        {
            List<Formato> lista = _dbcontext.Formatos.OrderByDescending(x => x.Id).ToList();
            Console.WriteLine(lista);
            return StatusCode(StatusCodes.Status200OK, lista);
        }

    }
}
