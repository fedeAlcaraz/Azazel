namespace Azazel_api.DTOs;
public class MensajeDTO
{
    public int IdMensaje {get; set;}
    public required int IdConversacion {get; set;}
    public required int IdUsuario {get; set;}
    public required string Contenido {get; set;}
    public required bool Success {get; set;}
    public DateTime FechaHora {get; set;}
}