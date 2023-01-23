using Microsoft.AspNetCore.Mvc;

namespace users.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class UserController : ControllerBase
  {
    [HttpGet]
    public string Get()
    {
      return "Hello World";
    }
  }
}