using Microsoft.EntityFrameworkCore;

namespace SuperHeroesDotNetWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server:.,DataBase=SuperHeroe, Trusted_Connection=true, TrustServerCertificate=true");
        }

        public DbSet<SuperHeroe> SuperHeores { get; set; }
    }
}
