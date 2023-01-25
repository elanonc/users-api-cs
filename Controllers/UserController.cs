using users.Models;
using users.Repository;
using Microsoft.AspNetCore.Mvc;

namespace users.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class UserController : ControllerBase
  {
    private readonly IUserRepository _repository;

    public UserController(IUserRepository repository)
    {
      this._repository = repository;
    }

    [HttpGet]
    public IActionResult Get()
    {
      return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Post(User user)
    {
      _repository.AddUser(user);
      return await _repository.SaveChangesAsync() 
        ? Ok("Usuário adicionado com sucesso") 
        : BadRequest("Erro ao salvar o usuário.");
    }

  }
}