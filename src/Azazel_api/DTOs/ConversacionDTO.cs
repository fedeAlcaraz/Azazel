namespace Azazel_api.DTOs;
public class ConversacionDTO
{
    public int IdConversacion {get; set;}
    public string ConversacionDir {get; set;}
    public DateTime Creation {get; set;}
    public DateTime LastMessage {get; set;}
}