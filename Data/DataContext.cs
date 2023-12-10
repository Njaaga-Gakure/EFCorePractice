using EFCorePractice.Entities;
using Microsoft.EntityFrameworkCore;


namespace EFCorePractice.Data
{
    public class DataContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0G9EJP0;Database=BREAKING_BAD;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Actor> Actors { get; set; }    
    }
}
