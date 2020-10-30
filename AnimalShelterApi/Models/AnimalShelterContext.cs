using Microsoft.EntityFrameworkCore;
namespace AnimalShelterApi.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
        : base(options)
    {

    }
    public DbSet<Animal> Animals { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
.HasData(
    new Animal { AnimalId = 1, AnimalType = "Cat", Breed = "Mancoon", AnimalName = "Roger", Age = 3, Sex = "Male", Details = "Roger is a Large Orange Mancoon cat that is fixed and shots are current. would be great with a family that has kids." },
    new Animal { AnimalId = 2, AnimalType = "Dog", Breed = "Labrador Retriever", AnimalName = "Goose", Age = 2, Sex = "Male", Details = "Goose is a fun,well mannered dog that was recently surrendered to us because his owner recently passed. he is fixed and up to date on his shots. he would be great for all families and is great with kids and other animals." },
    new Animal { AnimalId = 3, AnimalType = "Cat", Breed = "Tabby", AnimalName = "Skittles", Age = 7, Sex = "Female", Details = "Skittles is an older female cat that would do well in a small family with older kids, She is best by herself and has never been around dogs." },
    new Animal { AnimalId = 4, AnimalType = "Dog", Breed = "Coon Hound", AnimalName = "Beau", Age = 1, Sex = "Male", Details = "Beau is a typical Coon hound. he likes to play and is just now coming into his body. he is uncoordinated still a little but loves being around kids and his nose can still get him into a little trouble. great family dog" }
);
           
            }
  }
}