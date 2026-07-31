namespace Azazel_api.Data;
using Microsoft.EntityFrameworkCore;
using Azazel_api.Data.Configurations;
using Azazel_api.Models;
public class AzazelDbContext : DbContext{
    public AzazelDbContext(DbContextOptions<AzazelDbContext> options) : base(options)
    {
        
    }
    public DbSet<UsuarioModel> Usuarios { get; set; }
    public DbSet<ConversacionModel> Conversaciones { get; set; }
    public DbSet<MensajeModel> Mensajes { get; set; }
    public DbSet<MemoriaModel> Memorias { get; set; }
    public DbSet<AccionModel> Acciones { get; set; }
    public DbSet<ModeloIAModel> ModelosIA { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AzazelDbContext).Assembly);
        //las configuraciones estan en la carpeta configurations
    }
}