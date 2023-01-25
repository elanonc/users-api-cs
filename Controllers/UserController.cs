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
    public async Task<IActionResult> Get()
    {
      var usuarios = await _repository.GetAllUsers();
      return usuarios.Any() 
        ? Ok(usuarios) 
        : NoContent();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
      var usuario = await _repository.GetUser(id);
      return usuario != null 
        ? Ok(usuario) 
        : NotFound("Usuário não encontrado!");
    }

    [HttpPost]
    public async Task<IActionResult> Post(User user)
    {
      _repository.AddUser(user);
      return await _repository.SaveChangesAsync() 
        ? Ok("Usuário adicionado com sucesso!") 
        : BadRequest("Erro ao salvar o usuário.");
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, User user)
    {
      var usuarioUpdate = await _repository.GetUser(id);
      if (usuarioUpdate == null) 
      {
        return NotFound("Usuário não encontrado!");
      }

      usuarioUpdate.Name = user.Name ?? usuarioUpdate.Name;
      usuarioUpdate.BirthDate = user.BirthDate != new DateTime() 
      ? user.BirthDate : usuarioUpdate.BirthDate;

      _repository.UpdateUser(usuarioUpdate);

      return await _repository.SaveChangesAsync()
        ? Ok("Usuário atualizado com sucesso!")
        : BadRequest("Erro ao atualizar o usuário.");     
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      var usuarioDelete = await _repository.GetUser(id);
      if (usuarioDelete == null)
      {
        return NotFound("Usuário não encontrado!");
      }

      _repository.DeleteUser(usuarioDelete);

      return await _repository.SaveChangesAsync() 
        ? Ok("Usuário deletado com sucesso!")
        : BadRequest("Erro ao deletar o usuário.");
    }

  }
}