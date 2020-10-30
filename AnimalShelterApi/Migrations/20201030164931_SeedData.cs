using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelterApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "AnimalName", "AnimalType", "Breed", "Details", "Sex" },
                values: new object[,]
                {
                    { 1, 3, "Roger", "Cat", "Mancoon", "Roger is a Large Orange Mancoon cat that is fixed and shots are current. would be great with a family that has kids.", "Male" },
                    { 2, 2, "Goose", "Dog", "Labrador Retriever", "Goose is a fun,well mannered dog that was recently surrendered to us because his owner recently passed. he is fixed and up to date on his shots. he would be great for all families and is great with kids and other animals.", "Male" },
                    { 3, 7, "Skittles", "Cat", "Tabby", "Skittles is an older female cat that would do well in a small family with older kids, She is best by herself and has never been around dogs.", "Female" },
                    { 4, 1, "Beau", "Dog", "Coon Hound", "Beau is a typical Coon hound. he likes to play and is just now coming into his body. he is uncoordinated still a little but loves being around kids and his nose can still get him into a little trouble. great family dog", "Male" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);
        }
    }
}
