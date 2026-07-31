namespace Azazel_api.Models;
public class UsuarioModel
{
    public required string Nombre {get; set;}
    public required int IdUsuario {get; set;}
    public ICollection<AccionModel> Acciones { get; set; } = new List<AccionModel>();
}