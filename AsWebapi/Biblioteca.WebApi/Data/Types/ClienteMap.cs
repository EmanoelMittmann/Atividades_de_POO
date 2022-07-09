using Biblioteca.WebApi.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.WebApi.Data.Types
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("cliente");

            builder.Property(i => i.Id)
                .HasColumnName("id");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.Nome)
                .HasColumnName("nome")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(i => i.Telefone)
                .HasColumnName("telefone")
                .HasColumnType("VARCHAR")
                .HasMaxLength(16)
                .IsRequired();

            builder.Property(i => i.Email)
                .HasColumnName("email")
                .HasColumnType("VARCHAR")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(i => i.CPF)
                .HasColumnName("cpf")
                .HasColumnType("VARCHAR")
                .HasMaxLength(11)
                .IsRequired();
        }
    }
}