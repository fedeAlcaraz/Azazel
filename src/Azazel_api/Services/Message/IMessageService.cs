namespace Azazel_api.Services.MessageService;

using Azazel_api.DTOs;
using Azazel_api.Models;
public interface IMessageService
{
    List<MensajeModel> GetAll();
    MensajeModel? GetById(int id);
    void Create(MensajeDTO mensaje);
    void Update(int id, MensajeDTO mensaje);
    void Delete(int id);
}