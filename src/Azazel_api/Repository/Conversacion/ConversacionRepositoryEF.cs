namespace Azazel_api.Repository.Conversation;
using Azazel_api.Data;
using Azazel_api.Models;
public class ConversacionRepositoryEF : IConversacionRepository
{
    private readonly AzazelDbContext _context;
    public ConversacionRepositoryEF(AzazelDbContext context)
    {
        _context = context;
    }
    public List<ConversacionModel> GetAll()
    {
        return _context.Conversaciones.ToList();
    }
    public ConversacionModel? GetById(int id)
    {
        return _context.Conversaciones
            .FirstOrDefault(x => x.IdConversacion == id);
    }
    public void Create(ConversacionModel conversacion)
    {
        _context.Conversaciones.Add(conversacion);
        _context.SaveChanges();
    }
    public void Update(ConversacionModel conversacion)
    {
        _context.Conversaciones.Update(conversacion);
        _context.SaveChanges();
    }
    public void Delete(int id)
    {
        var conversacion = GetById(id);

        if (conversacion != null)
        {
            _context.Conversaciones.Remove(conversacion);
            _context.SaveChanges();
        }
    }
}