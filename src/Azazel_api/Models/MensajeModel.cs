namespace Azazel_api.Models;
public class MensajeModel
{
    public required int IdMensaje {get; set;}
    public required int IdConversacion {get; set;}
    public required int IdUsuario {get; set;}
    public required string Contenido {get; set;}
    public required bool Success {get; set;}
    public required DateTime FechaHora {get; set;}
    public required string Emisor {get; set;}
    public ConversacionModel Conversacion { get; set; } = null!;
}