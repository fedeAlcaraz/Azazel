namespace Azazel_api.Data.Configurations;
using Azazel_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
public class Configuration : IEntityTypeConfiguration<MensajeModel>{
    public void Configure(EntityTypeBuilder<MensajeModel> builder)
    {
        builder.ToTable("mensajes");
        builder.HasKey(x => x.IdMensaje);
        builder.Property(x => x.IdMensaje)
               .HasColumnName("id_mensaje");
        builder.Property(x => x.IdConversacion)
               .HasColumnName("id_conversacion");
        builder.Property(x => x.Emisor)
               .HasColumnName("emisor");
        builder.Property(x => x.Contenido)
               .HasColumnName("contenido");
        builder.Property(x => x.Success)
               .HasColumnName("success");
        builder.Property(x => x.FechaHora)
               .HasColumnName("fecha_hora")
               .HasDefaultValueSql("CURRENT_TIMESTAMP");
        builder.HasOne(x => x.Conversacion)
               .WithMany(x => x.Mensajes)
               .HasForeignKey(x => x.IdConversacion)
               .OnDelete(DeleteBehavior.Cascade);
    }
}