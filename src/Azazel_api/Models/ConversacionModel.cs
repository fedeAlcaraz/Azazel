namespace Azazel_api.Models;
public class ConversacionModel
{
    public required int IdConversacion {get; set;}
    public ICollection<MensajeModel> Mensajes { get; set; } = new List<MensajeModel>();
    public ICollection<MemoriaModel> Memorias { get; set; } = new List<MemoriaModel>();
    public ICollection<AccionModel> Acciones { get; set; } = new List<AccionModel>();
    public required string ConversacionDir {get; set;}
    public required DateTime Creation {get; set;}
    public required DateTime? LastMessage {get; set;}
}