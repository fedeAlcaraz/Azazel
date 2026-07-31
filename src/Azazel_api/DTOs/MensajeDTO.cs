namespace Azazel_api.DTOs;
public class MensajeDTO
{
    public required int IdMensaje {get; set;}
    public required int IdConversacion {get; set;}
    public required bool emisor {get; set;}
    public required string Contenido {get; set;}
    public required bool Success {get; set;}
    public required DateTime FechaHora {get; set;}
}