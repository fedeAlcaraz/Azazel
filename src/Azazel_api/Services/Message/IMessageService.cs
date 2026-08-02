namespace Azazel_api.Services.MessageService;
using Azazel_api.Models;
public interface IMessageService
{
    List<MensajeModel> GetAll();
    MensajeModel? GetById(int id);
    void Create(MensajeModel usuario);
    void Update(MensajeModel usuario);
    void Delete(int id);
}