using Microsoft.AspNetCore.Mvc;
using Azazel_api.DTOs;
using Azazel_api.Services.ConversationService;
namespace Azazel_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConversationController : ControllerBase
    {
        private readonly IConversationService _ConversationService;
        public ConversationController(IConversationService conversationService)
        {
            _ConversationService = conversationService;
        }
        [HttpGet]
        public ActionResult<List<ConversacionDTO>> GetAll()
        {
            var conversations = _ConversationService.GetAll();
            return Ok(conversations);
        }

        [HttpGet("{id}")]
        public ActionResult<ConversacionDTO> GetById(int id)
        {
            var conversacion = _ConversationService.GetById(id);
            if (conversacion == null)
            {
                return NotFound();
            }
            return Ok(conversacion);
        }
        [HttpPost]
        public ActionResult<ConversacionDTO> Create (ConversacionDTO conversacion)
        {
            _ConversationService.Create(conversacion);
            return Ok("conversacion creada correctamente");
        }
        [HttpPut("{id}")]
        public ActionResult Update(int id, ConversacionDTO conversacion)
        {
            try
            {
                _ConversationService.Update(id, conversacion);
                return Ok("conversacion actualizada correctamente");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _ConversationService.Delete(id);
                return Ok("conversacion eliminada correctamente");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}