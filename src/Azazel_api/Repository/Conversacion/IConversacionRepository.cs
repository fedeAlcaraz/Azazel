namespace Azazel_api.Repository.Conversation;
using Azazel_api.Models;
public interface IConversacionRepository
{
    List<ConversacionModel> GetAll();
    ConversacionModel? GetById(int id);
    void Create(ConversacionModel conversacion);
    void Update(ConversacionModel conversacion);
    void Delete(int id);
}