namespace Azazel_api.DTOs;
public class ConversacionDTO
{
    public required int IdConversacion {get; set;}
    public required string ConversacionDir {get; set;}
    public required DateTime Creation {get; set;}
    public required DateTime LastMessage {get; set;}
}