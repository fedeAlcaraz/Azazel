namespace Azazel_api.Data.Configurations;
using Azazel_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
public class ModeloIAConfiguration : IEntityTypeConfiguration<ModeloIAModel>{
    public void Configure(EntityTypeBuilder<ModeloIAModel> builder)
    {
        builder.ToTable("modelosIA");
        builder.HasKey(x => x.Id_IA);
        builder.Property(x => x.Id_IA)
               .HasColumnName("id_ia");
        builder.Property(x => x.Nombre)
               .HasColumnName("nombre")
               .HasMaxLength(40);
        builder.Property(x => x.Activo)
               .HasColumnName("activo");
    }
}