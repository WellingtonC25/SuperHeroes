using SuperHeroesDotNetWebApi.Models;

namespace SuperHeroesDotNetWebApi.Services
{
    public interface ISuperHeroeService
    {
        List<SuperHeroe> GetAllHeroes();
        SuperHeroe? GetSingleHeroe(int Id);
        List<SuperHeroe>? AddHeroe(SuperHeroe superHeroeParameter);
        List<SuperHeroe>? PutSingleHeroe(int Id, SuperHeroe superHeroeParameter);
        List<SuperHeroe>? DeleteSingleHeroe(int Id);
    }
}
