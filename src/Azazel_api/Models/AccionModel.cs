namespace Azazel_api.Models;
public class AccionModel
{
    public required int IdAccion {get; set;}
    public required int IdUsuario {get; set;}
    public required int IdConversacion {get; set;}
    public required UsuarioModel Usuario { get; set; }
    public required ConversacionModel Conversacion { get; set; }
    public required EnumAcciones TipoAccion {get; set;}
    public required bool Exito {get; set;}
    public required TimeSpan TimeResponse {get; set;}
    public DateTime FechaHora { get; set; }
}