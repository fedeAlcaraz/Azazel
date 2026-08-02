namespace Azazel_api.Repository.Message;
using Azazel_api.Models;

public interface IMensajeRepository
{
    List<MensajeModel> GetAll();
    MensajeModel? GetById(int id);
    void Create(MensajeModel mensaje);
    void Update(MensajeModel mensaje);
    void Delete(int id);
}