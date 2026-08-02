namespace Azazel_api.Services.UsuarioService;
using Azazel_api.Models;
using Azazel_api.Repository.User;

public class MensajeService : IUsuarioService
{
    private readonly IUserRepository _repository;

    public MensajeService(IUserRepository repository)
    {
        _repository = repository;
    }

    public List<UsuarioModel> GetAll()
        => _repository.GetAll();

    public UsuarioModel? GetById(int id)
        => _repository.GetById(id);

    public void Create(UsuarioModel usuario)
        => _repository.Create(usuario);

    public void Update(UsuarioModel usuario)
        => _repository.Update(usuario);

    public void Delete(int id)
        => _repository.Delete(id);
}