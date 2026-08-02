namespace Azazel_api.Services.ConversationService;
using Azazel_api.Models;
using Azazel_api.Repository.Conversation;

public class ConversacionService : IConversationService
{
    private readonly IConversacionRepository _repository;

    public ConversacionService(IConversacionRepository repository)
    {
        _repository = repository;
    }

    public List<ConversacionModel> GetAll()
        => _repository.GetAll();

    public ConversacionModel? GetById(int id)
        => _repository.GetById(id);

    public void Create(ConversacionModel conversacion)
        => _repository.Create(conversacion);

    public void Update(ConversacionModel conversacion)
        => _repository.Update(conversacion);

    public void Delete(int id)
        => _repository.Delete(id);
}