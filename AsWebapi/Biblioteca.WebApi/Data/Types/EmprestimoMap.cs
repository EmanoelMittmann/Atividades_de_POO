using Biblioteca.WebApi.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.WebApi.Data.Types
{
    public class EmprestimoMap : IEntityTypeConfiguration<Emprestimo>
    {
        public void Configure(EntityTypeBuilder<Emprestimo> builder)
        {
            builder.ToTable("emprestimo");

            builder.Property(i => i.Id)
                .HasColumnName("id");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.DataEmprestimo)
                .HasColumnName("data_emprestimo")
                .HasColumnType("SMALLDATETIME")
                .IsRequired();

            builder.Property(i => i.DataDevolucao)
                .HasColumnName("data_devolucao")
                .HasColumnType("SMALLDATETIME")
                .IsRequired();

            builder.Property(i => i.LivroId)
                .HasColumnName("livro_id")
                .HasColumnType("INTEGER")
                .IsRequired();

            builder.Property(i => i.ClienteId)
                .HasColumnName("cliente_id")
                .HasColumnType("INTEGER")
                .IsRequired();

            //Relacionamentos

            builder.HasOne(i => i.Livro)
                .WithOne(i => i.Emprestimo)
                .HasConstraintName("FK_Emprestimo_Livro")
                .HasForeignKey<Emprestimo>(i => i.LivroId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Cliente)
                .WithMany(x => x.Emprestimos)
                .HasConstraintName("FK_Emprestimo_Cliente")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}