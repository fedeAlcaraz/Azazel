namespace Azazel_api.Services.UsuarioService;

using Azazel_api.DTOs;
using Azazel_api.Models;
public interface IUsuarioService
{
    List<UsuarioModel> GetAll();
    UsuarioModel? GetById(int id);
    void Create(UsuarioDTO usuario);
    void Update(int id, UsuarioDTO usuario);
    void Delete(int id);
}