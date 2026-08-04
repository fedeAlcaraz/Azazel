namespace Azazel_api.Data.Configurations;
using Azazel_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
public class ConversationConfiguration : IEntityTypeConfiguration<ConversacionModel>{
    public void Configure(EntityTypeBuilder<ConversacionModel> builder)
    {
        builder.ToTable("conversaciones");
        builder.HasKey(x => x.IdConversacion);
        builder.Property(x => x.IdConversacion)
               .HasColumnName("id_conversacion")
               .ValueGeneratedOnAdd();
        builder.Property(x => x.ConversacionDir)
               .HasColumnName("dir")
               .HasMaxLength(100);
        builder.Property(x => x.Creation)
               .HasColumnName("date_creation")
               .HasDefaultValueSql("CURRENT_TIMESTAMP")
               .ValueGeneratedOnAdd();
        builder.Property(x => x.LastMessage)
               .HasColumnName("date_last_message")
               .ValueGeneratedNever();
    }
}