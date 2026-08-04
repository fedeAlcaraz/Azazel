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
               .HasColumnName("id_mensaje")
               .ValueGeneratedOnAdd();
        builder.Property(x => x.IdConversacion)
               .HasColumnName("id_conversacion");
        builder.Property(x => x.IdUsuario)
               .HasColumnName("id_usuario");
        builder.Property(x => x.Contenido)
               .HasColumnName("contenido");
        builder.Property(x => x.Success)
               .HasColumnName("success");
        builder.Property(x => x.FechaHora)
               .HasColumnName("fecha_hora")
               .HasDefaultValueSql("CURRENT_TIMESTAMP");
       }
}