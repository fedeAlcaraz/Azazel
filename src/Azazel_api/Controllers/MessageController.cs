using Microsoft.AspNetCore.Mvc;
using Azazel_api.DTOs;
using Azazel_api.Services.MessageService;
namespace Azazel_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;
        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }
        [HttpGet]
        public ActionResult<List<MensajeDTO>> GetAll()
        {
            var mensajes = _messageService.GetAll();
            return Ok(mensajes);
        }

        [HttpGet("{id}")]
        public ActionResult<MensajeDTO> GetById(int id)
        {
            var mensaje = _messageService.GetById(id);
            if (mensaje == null)
            {
                return NotFound();
            }
            return Ok(mensaje);
        }
        [HttpPut("{id}")]
        public ActionResult UpdateMessage(int id, MensajeDTO mensaje)
        {
            try
            {
                _messageService.Update(id, mensaje);
                return Ok("usuario actualizado correctamente");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
