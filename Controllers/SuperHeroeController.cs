using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroesDotNetWebApi.Services;

namespace SuperHeroesDotNetWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroeController : ControllerBase
    {
        private readonly ISuperHeroeService _superHeroeService;

        public SuperHeroeController( ISuperHeroeService superHeroeService)
        {
            _superHeroeService = superHeroeService;
        }
        [HttpGet]
        public async Task<ActionResult<List<SuperHeroe>>> GetAllHeroes() {

            return Ok(_superHeroeService.GetAllHeroes());
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<SuperHeroe>> GetSingleHeroe( int Id)
        {
            var heroe = _superHeroeService.GetSingleHeroe(Id);
            if (heroe is null)
                return NotFound("Este heroe no existe, perdon");
            return Ok(heroe);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHeroe>>> AddHeroe(SuperHeroe superHeroeParameter)
        {
            return Ok(_superHeroeService.AddHeroe(superHeroeParameter));
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<List<SuperHeroe>>> PutSingleHeroe(int Id, SuperHeroe superHeroeParameter)
        {
            var heroe = _superHeroeService.PutSingleHeroe(Id, superHeroeParameter);

            if (heroe is null)
                return NotFound("Este heroe no existe, perdon");

            return Ok(heroe);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<SuperHeroe>>> DeleteSingleHeroe(int Id)
        {
            var heroe = _superHeroeService.DeleteSingleHeroe(Id);
            if (heroe is null)
                return NotFound("Ningun heroe por eliminar");

            return Ok(heroe);
        }
    }
}
