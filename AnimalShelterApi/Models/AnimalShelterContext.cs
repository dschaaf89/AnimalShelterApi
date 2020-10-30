using Microsoft.EntityFrameworkCore;
namespace AnimalShelterApi.Models
{
    public class AnimalShelterContext :DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
            {

            }
            public DbSet<Animal> Animals { get; set; }
            protected override void OnModelCreating(ModelBuilder builder)
            {
                
            }
    }
}