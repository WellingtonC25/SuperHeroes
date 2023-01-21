using SuperHeroesDotNetWebApi.Models;

namespace SuperHeroesDotNetWebApi.Services
{
    public class SuperHeroeService : ISuperHeroeService
    {
        private static List<SuperHeroe> superHeroe = new List<SuperHeroe>{
                new SuperHeroe{
                    Id = 1,
                    NombreHeroe = "Spider Man",
                    Nombre = "Peter",
                    Apellidos="Parker",
                    Lugar = "New York City"
                    },
                new SuperHeroe{
                    Id = 2,
                    NombreHeroe = "Iron Man",
                    Nombre = "Tony",
                    Apellidos="Stark",
                    Lugar = "New York City"
                    }
         };

        public List<SuperHeroe> AddHeroe(SuperHeroe superHeroeParameter)
        {
            superHeroe.Add(superHeroeParameter);

            return superHeroe;
        }

        public List<SuperHeroe>? DeleteSingleHeroe(int Id)
        {
            var heroe = superHeroe.Find(x => x.Id == Id);
            if (heroe is null)
                return null;

            superHeroe.Remove(heroe);
            return superHeroe;
        }

        public List<SuperHeroe> GetAllHeroes()
        {
            return superHeroe;

        }

        public SuperHeroe? GetSingleHeroe(int Id)
        {

            var heroe = superHeroe.Find(x => x.Id == Id);
            if (heroe is null)
                return null;
            return heroe;
        }

        public List<SuperHeroe>? PutSingleHeroe(int Id, SuperHeroe superHeroeParameter)
        {
            var heroe = superHeroe.Find(x => x.Id == Id);

            if (heroe is null)
                return null;

            heroe.Nombre = superHeroeParameter.Nombre;
            heroe.Apellidos = superHeroeParameter.Apellidos;
            heroe.Lugar = superHeroeParameter.Lugar;

            return superHeroe;
        }
    }
}
