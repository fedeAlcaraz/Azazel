namespace Azazel_api.Services.ConversationService;
using Azazel_api.Models;
public interface IConversationService
{
    List<ConversacionModel> GetAll();
    ConversacionModel? GetById(int id);
    void Create(ConversacionModel usuario);
    void Update(ConversacionModel usuario);
    void Delete(int id);
}