namespace Azazel_api.Data.Configurations;
using Azazel_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
public class AccionConfiguration : IEntityTypeConfiguration<AccionModel>
{
    public void Configure(EntityTypeBuilder<AccionModel> builder)
    {
        builder.ToTable("acciones");
        builder.HasKey(x => x.IdAccion);
        builder.Property(x => x.IdAccion)
               .HasColumnName("id_accion")
               .ValueGeneratedOnAdd();
        builder.Property(x => x.IdUsuario)
               .HasColumnName("id_usuario");
        builder.Property(x => x.IdConversacion)
               .HasColumnName("id_conversacion");
        builder.Property(x => x.TipoAccion)
               .HasColumnName("tipo")
               .HasConversion<string>()
               .HasMaxLength(20);
        builder.Property(x => x.Exito)
               .HasColumnName("success");
        builder.Property(x => x.TimeResponse)
               .HasColumnName("time_response");
        builder.Property(x => x.FechaHora)
               .HasColumnName("fecha_hora")
               .HasDefaultValueSql("CURRENT_TIMESTAMP");
        builder.HasOne(x => x.Usuario)
               .WithMany(x => x.Acciones)
               .HasForeignKey(x => x.IdUsuario);
        builder.HasOne(x => x.Conversacion)
               .WithMany(x => x.Acciones)
               .HasForeignKey(x => x.IdConversacion);
    }
}