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
    }
}