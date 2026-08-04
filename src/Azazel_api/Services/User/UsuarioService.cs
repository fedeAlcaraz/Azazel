namespace Azazel_api.Services.UsuarioService;

using Azazel_api.DTOs;
using Azazel_api.Models;
using Azazel_api.Repository.User;

public class UsuarioService : IUsuarioService
{
    private readonly IUserRepository _repository;

    public UsuarioService(IUserRepository repository)
    {
        _repository = repository;
    }

    public List<UsuarioModel> GetAll()
        => _repository.GetAll();

    public UsuarioModel? GetById(int id)
        => _repository.GetById(id);

    public void Create(UsuarioDTO usuario){
        var usuarioModel = new UsuarioModel
        {
          IdUsuario = usuario.IdUsuario,
          Nombre = usuario.Nombre
        };
         _repository.Create(usuarioModel);
    }

    public void Update(int id, UsuarioDTO dto)
    {
    var usuario = _repository.GetById(id);

    if (usuario == null)
        throw new Exception("Usuario no encontrado.");
    usuario.Nombre = dto.Nombre;
    _repository.Update(usuario);
    }
    public void Delete(int id)
        => _repository.Delete(id);
}