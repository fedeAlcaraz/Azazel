namespace Azazel_api.Services.UsuarioService;
using Azazel_api.Models;
public interface IUsuarioService
{
    List<UsuarioModel> GetAll();
    UsuarioModel? GetById(int id);
    void Create(UsuarioModel usuario);
    void Update(UsuarioModel usuario);
    void Delete(int id);
}