using users.Models;
using Microsoft.AspNetCore.Mvc;

namespace users.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class UserController : ControllerBase
  {

    private static List<User> Users()
    {
      return new List<User>{
        new User{ Name = "Elano", Id = 1, BirthDate = new DateTime(2001, 09, 14) }
      };
    }

    [HttpGet]
    public IActionResult Get()
    {
      return Ok(Users());
    }

    [HttpPost]
    public IActionResult Post(User user)
    {
      var usuarios = Users();
      usuarios.Add(user);
      return Ok(usuarios);
    }

  }
}