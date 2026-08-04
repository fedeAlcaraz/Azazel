using Microsoft.AspNetCore.Mvc;
using Azazel_api.DTOs;
using Azazel_api.Services.UsuarioService;
namespace Azazel_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUsuarioService _userService;
        public UserController(IUsuarioService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public ActionResult<List<UsuarioDTO>> GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
        [HttpGet("{id}")]
        public ActionResult<UsuarioDTO> GetById(int id)
        {
            var user = _userService.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        [HttpPost]
        public ActionResult<UsuarioDTO> Create (UsuarioDTO usuario)
        {
            _userService.Create(usuario);
            return Ok("usuario creado correctamente");
        }
        [HttpPut("{id}")]
        public ActionResult UpdateUser(int id, UsuarioDTO usuario)
        {
            try
            {
                _userService.Update(id, usuario);
                return Ok("usuario actualizado correctamente");
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
                _userService.Delete(id);
                return Ok("usuario eliminado correctamente");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}