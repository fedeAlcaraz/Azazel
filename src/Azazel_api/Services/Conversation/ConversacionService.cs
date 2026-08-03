namespace Azazel_api.Services.ConversationService;

using Azazel_api.DTOs;
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

    public void Create(ConversacionDTO conversacion)
    {
        var nuevaConversacion = new ConversacionModel
        {
            IdConversacion = conversacion.IdConversacion,
            ConversacionDir = conversacion.ConversacionDir,
            Creation = conversacion.Creation,
            LastMessage = conversacion.LastMessage  
        };
         _repository.Create(nuevaConversacion);
    }

    public void Update(int id, ConversacionDTO conversacion)
    {
        var obtenerConversacion = _repository.GetById(id);
    if (obtenerConversacion == null)
        throw new Exception("Mensaje no encontrado.");
    _repository.Update(obtenerConversacion);
    } 
    public void Delete(int id)
        => _repository.Delete(id);
}