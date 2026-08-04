namespace Azazel_api.Data.Configurations;
using Azazel_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
public class MemoriaConfiguration : IEntityTypeConfiguration<MemoriaModel>{
    public void Configure(EntityTypeBuilder<MemoriaModel> builder)
    {
        builder.ToTable("memorias");
        builder.HasKey(x => x.IdMemoria);
        builder.Property(x => x.IdMemoria)
               .HasColumnName("id_memoria")
               .ValueGeneratedOnAdd();
        builder.Property(x => x.IdConversacion)
               .HasColumnName("id_conversacion");
        builder.Property(x => x.MemoriaDir)
               .HasColumnName("dir")
               .HasMaxLength(100);
        builder.HasOne(x => x.Conversacion)
               .WithMany(x => x.Memorias)
               .HasForeignKey(x => x.IdConversacion);
    }
}