using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividadeAS.models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace atividadeAS.Types
{
    public class TypeEmprestimo : IEntityTypeConfiguration<Emprestimo>
    {
        public void Configure(EntityTypeBuilder<Emprestimo> builder)
        {
            builder.ToTable("emprestimo");
            builder.Property(emprestimo => emprestimo.data_entrega).HasColumnType("date");
            builder.Property(emprestimo => emprestimo.data_emprestimo).HasColumnType("date");
            builder.Property(emprestimo => emprestimo.prazo).HasColumnType("Int");
        }
    }
}