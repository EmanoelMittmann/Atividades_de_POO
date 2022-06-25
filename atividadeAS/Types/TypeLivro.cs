using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using atividadeAS.models.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace atividadeAS.Types
{
    public class TypeLivro : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");
            builder.HasKey(Livro => Livro.Id_Livro);
            builder.Property(Livro => Livro.Titulo).HasColumnType("varchar(50)");
            builder.Property(Livro => Livro.Num_edit).HasColumnType("Int");
            builder.Property(Livro => Livro.Volume).HasColumnType("Int");
        }
    }
}