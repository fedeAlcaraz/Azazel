namespace Azazel_api.Services.ConversationService;

using Azazel_api.DTOs;
using Azazel_api.Models;
public interface IConversationService
{
    List<ConversacionModel> GetAll();
    ConversacionModel? GetById(int id);
    void Create(ConversacionDTO conversacion);
    void Update(int id, ConversacionDTO conversacion);
    void Delete(int id);
}