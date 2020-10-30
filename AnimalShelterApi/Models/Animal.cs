using System.ComponentModel.DataAnnotations;
namespace AnimalShelterApi.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    [Required]
    public string AnimalType { get; set; }
    [Required]
    public string Breed { get; set; }
    [Required]
    public string AnimalName { get; set; }
    [Range(0, 100, ErrorMessage = "Age must be between 0 and 100 beacuse we might have a parrot which live for ever")]
    public int Age { get; set; }
    [Required]
    public string Sex { get; set; }
    [Required]
    public string Details { get; set; }


  }
}