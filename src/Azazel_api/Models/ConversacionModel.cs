namespace Azazel_api.Models;
public class ConversacionModel
{
    public int IdConversacion {get; set;}
    public string ConversacionDir {get; set;}
    public DateTime Creation {get; set;}
    public DateTime LastMessage {get; set;}
}