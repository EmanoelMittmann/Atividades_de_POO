using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividadeAS.models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace atividadeAS.Types
{
    public class TypeEmprestimo : IEntityTypeConfiguration<EmprestimoDomain>
    {
        public void Configure(EntityTypeBuilder<EmprestimoDomain> builder)
        {
            builder.ToTable("emprestimo");
            builder.Property(emprestimo => emprestimo.Id_empres)
                .HasColumnName("id_empres");
            builder.HasKey(emprestimo => emprestimo.Id_empres);
            builder.Property(emprestimo => emprestimo.data_entrega)
                .HasColumnName("data_entrega")
                .HasColumnType("SMALLDATETIME");
            builder.Property(emprestimo => emprestimo.data_emprestimo)
                .HasColumnName("data_emprestimo")
                .HasColumnType("SMALLDATETIME");
            builder.Property(emprestimo => emprestimo.prazo)
                .HasColumnName("prazo")
                .HasColumnType("INTEGER");

            //Relacionamento um pra um

            builder.HasOne(i => i.Livro)
                .WithOne(i => i.Emprestimo)
                .HasConstraintName("FK_Address_Customer")
                .HasForeignKey<EmprestimoDomain>(i => i.LivroId)
                .OnDelete(DeleteBehavior.Cascade);

            //Relacionamento um pra muitos

            builder.HasOne(x => x.User)
                .WithMany(x => x.Emprestimos)
                .HasConstraintName("FK_Emprestimo_Usuario")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}