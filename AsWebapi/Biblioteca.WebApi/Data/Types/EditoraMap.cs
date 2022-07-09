using Biblioteca.WebApi.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.WebApi.Data.Types
{
    public class EditoraMap : IEntityTypeConfiguration<Editora>
    {
        public void Configure(EntityTypeBuilder<Editora> builder)
        {
            builder.ToTable("editora");

            builder.Property(i => i.Id)
                .HasColumnName("id");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.Nome)
                .HasColumnName("nome")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(i => i.Cidade)
                .HasColumnName("cidade")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80)
                .IsRequired();
        }
    }
}