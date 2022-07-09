using Biblioteca.WebApi.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.WebApi.Data.Types
{
    public class AutorMap : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder.ToTable("autor");

            builder.Property(i => i.Id)
                .HasColumnName("id");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.Nome)
                .HasColumnName("nome")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80)
                .IsRequired();
        }
    }
}