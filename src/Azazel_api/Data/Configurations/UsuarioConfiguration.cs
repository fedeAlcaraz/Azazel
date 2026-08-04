namespace Azazel_api.Data.Configurations;
using Azazel_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
public class UsuarioConfiguration : IEntityTypeConfiguration<UsuarioModel>{
    public void Configure(EntityTypeBuilder<UsuarioModel> builder)
    {
        builder.ToTable("usuarios");
        builder.HasKey(x => x.IdUsuario);
        builder.Property(x => x.IdUsuario)
               .HasColumnName("id_usuario")
               .ValueGeneratedOnAdd();
        builder.Property(x => x.Nombre)
               .HasColumnName("nombre")
               .HasMaxLength(40);
    }
}