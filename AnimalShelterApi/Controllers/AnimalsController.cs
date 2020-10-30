using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace AnimalShelterApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }


    // GET api/animals
    [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get(string animalType,string sex,int age )
    {
      var query = _db.Animals.AsQueryable();
      if(animalType != null)
      {
         query = query.Where(entry => entry.AnimalType.ToUpper() == animalType.ToUpper() );
      }
      if(sex != null)
      {
         query = query.Where(entry => entry.Sex.ToUpper() == sex.ToUpper() );
      }
      if( age != 0)
      {
        if(age>0&&age<=2)
      {
         query = query.Where(entry => entry.Age <= age );
      }
        else
        {
            query = query.Where(entry => entry.Age >= age );
        }
      }

      return query.ToList();
    }

    // GET api/animals/5
    [HttpGet("{id}")]
    public ActionResult<Animal> Get(int id)
    {
      return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
    }
    [Authorize]
    // POST api/animals
    [HttpPost]
    public void Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
    }
    [Authorize]
    // PUT api/animals/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Animal animal)
    {
      animal.AnimalId = id;
      _db.Entry(animal).State = EntityState.Modified;
      _db.SaveChanges();
    }
    [Authorize]
    // DELETE api/animals/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var animalToDelete = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
      _db.Animals.Remove(animalToDelete);
      _db.SaveChanges();
    }
    
    //Random api/animals/random
    [HttpGet("random")]
    public ActionResult<Animal> GetRandom()
    {
      List<Animal> allAnimals = _db.Animals.ToList();
      var random = new Random();
      int temp = random.Next(0, allAnimals.Count() - 1);
      return allAnimals[temp];
    }
  }
}
