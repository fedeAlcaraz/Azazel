namespace Azazel_api.Models;
public class MensajeModel
{
    public int IdMensaje {get; set;}
    public int IdConversacion {get; set;}
    public bool emisor {get; set;}
    public string Contenido {get; set;}
    public bool Success {get; set;}
    public DateTime FechaHora {get; set;}
}