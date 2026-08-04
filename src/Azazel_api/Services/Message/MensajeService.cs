namespace Azazel_api.Services.MessageService;

using Azazel_api.DTOs;
using Azazel_api.Models;
using Azazel_api.Repository.Message;

public class MensajeService : IMessageService
{
    private readonly IMensajeRepository _repository;

    public MensajeService(IMensajeRepository repository)
    {
        _repository = repository;
    }

    public List<MensajeModel> GetAll()
        => _repository.GetAll();

    public MensajeModel? GetById(int id)
        => _repository.GetById(id);

    public void Create(MensajeDTO mensaje){
        var mensajeModel = new MensajeModel
        {
            IdMensaje = mensaje.IdMensaje,
            IdConversacion = mensaje.IdConversacion,
            IdUsuario = mensaje.IdUsuario,
            Contenido = mensaje.Contenido,
            Success = mensaje.Success,
            FechaHora = mensaje.FechaHora
        };
        _repository.Create(mensajeModel);
    }
    public void Update(int id, MensajeDTO mensaje)
    {
        var obtenerMensaje = _repository.GetById(id);

    if (obtenerMensaje == null)
        throw new Exception("Mensaje no encontrado.");
    _repository.Update(obtenerMensaje);
    } 

    public void Delete(int id)
        => _repository.Delete(id);
}