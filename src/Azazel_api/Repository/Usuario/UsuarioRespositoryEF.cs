namespace Azazel_api.Repository.User;
using Azazel_api.Data;
using Azazel_api.Models;
public class UsuarioRepositoryEF : IUserRepository
{
    private readonly AzazelDbContext _context;
    public UsuarioRepositoryEF(AzazelDbContext context)
    {
        _context = context;
    }
    public List<UsuarioModel> GetAll()
    {
        return _context.Usuarios.ToList();
    }
    public UsuarioModel? GetById(int id)
    {
        return _context.Usuarios
            .FirstOrDefault(x => x.IdUsuario == id);
    }
    public void Create(UsuarioModel usuario)
    {
        _context.Usuarios.Add(usuario);
        _context.SaveChanges();
    }
    public void Update(UsuarioModel usuario)
    {
        _context.SaveChanges();
    }
    public void Delete(int id)
    {
        var usuario = GetById(id);

        if (usuario != null)
        {
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }
    }
}