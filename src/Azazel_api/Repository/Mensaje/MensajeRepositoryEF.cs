namespace Azazel_api.Repository.Message;
using Microsoft.EntityFrameworkCore;
using Azazel_api.Data;
using Azazel_api.Models;
public class MensajeRepositoryEF : IMensajeRepository
{
    private readonly AzazelDbContext _context;
    public MensajeRepositoryEF(AzazelDbContext context)
    {
        _context = context;
    }
    public List<MensajeModel> GetAll()
    {
        var query = _context.Mensajes.AsQueryable();
        Console.WriteLine(query.ToQueryString());
        return _context.Mensajes.ToList();
    }
    public MensajeModel? GetById(int id)
    {
        return _context.Mensajes
            .FirstOrDefault(x => x.IdMensaje == id);
    }
    public void Create(MensajeModel mensaje)
    {
        _context.Mensajes.Add(mensaje);
        _context.SaveChanges();
    }
    public void Update(MensajeModel mensaje)
    {
        _context.Mensajes.Update(mensaje);
        _context.SaveChanges();
    }
    public void Delete(int id)
    {
        var Mensaje = GetById(id);

        if (Mensaje != null)
        {
            _context.Mensajes.Remove(Mensaje);
            _context.SaveChanges();
        }
    }
}