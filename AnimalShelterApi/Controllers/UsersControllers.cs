using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using AnimalShelterApi.Services;
using AnimalShelterApi.Models;
namespace AnimalShelterApi.Controllers
{
  [Authorize]
  [ApiController]
  [Route("api/[controller]")]
  public class UsersControllers : ControllerBase
  {
    private IUserService _userService;
    public UsersControllers(IUserService userService)
    {
      _userService = userService;
    }
    [AllowAnonymous]
    [HttpPost("authenticate")]
    public IActionResult Authenticate([FromBody] User userparam)
    {
      var user = _userService.Authenticate(userparam.Username, userparam.Password);
      if (user == null)
        return BadRequest(new { message = "Username or password is incorrect" });
      return Ok(user);
    }
    [HttpGet]
    public IActionResult GetAll()
    {
      var users = _userService.GetAll();
      return Ok(users);
    }
  }
}