namespace Azazel_api.Repository.User;
using Azazel_api.Models;
public interface IUserRepository
{
    List<UsuarioModel>GetAll();
    UsuarioModel? GetById(int id);
    void Create(UsuarioModel usuario);
    void Update(UsuarioModel usuario);
    void Delete(int id);
}